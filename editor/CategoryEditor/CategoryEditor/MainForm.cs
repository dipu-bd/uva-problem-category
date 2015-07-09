using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CategoryEditor
{
    public partial class MainForm : Form
    {
        const string EXTENSION = ".cat";
        const string BIG_FOLDER = "big.png";
        const string ROOT_FOLDER = "root.png";
        const string BRANCH_LIST = "blist.png";
        const string BRANCH_FOLDER = "bfolder.png";
        const string PROB_FOLDER = "pfolder.png";
        const string PROB_NORMAL = "pfile.png";
        const string PROB_STAR = "pstar.png";

        string selectedFile = null;
        CategoryBranch loadedBranch = null;
        TreeNode currentNode = null;

        public MainForm()
        {
            InitializeComponent();

            //load default state 
            loadCategoryList();
            closeOpenedBranch();
            closeEditing();
        }

        //
        // My Functions
        //
        #region Basic functions

        string indexFolder()
        {
            return Path.GetDirectoryName(Properties.Settings.Default.INDEX);
        }

        bool isValidFile(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                return false;

            char[] invalid = Path.GetInvalidFileNameChars();
            if (filename.IndexOfAny(invalid) >= 0)
                return false;

            return !File.Exists(filename);
        }

        #endregion

        #region Loader methods

        //
        // Category list
        //
        void loadCategoryList()
        {
            try
            {
                string path = indexBox.Text;

                fileList.Items.Clear();
                List<string> data = new List<string>();
                var arr = Directory.GetFiles(Path.GetDirectoryName(path), "*.cat");
                foreach (string v in arr)
                {
                    string name = Path.GetFileName(v);
                    fileList.Items.Add(getFileListItem(v));
                    data.Add(name);
                }

                panel1.Enabled = true;
                fileList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                fileList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

                //save json data
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                panel1.Enabled = false;
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        ListViewItem getFileListItem(string path)
        {
            ListViewItem lvi = new ListViewItem(Path.GetFileName(path));
            lvi.SubItems.Add(path);
            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems[1].ForeColor = Color.Silver;
            lvi.ImageKey = BIG_FOLDER;
            return lvi;
        }

        //
        // Category Branch
        //
        void loadCategoryBranch(string filename = null)
        {
            try
            {
                //first close previous branch
                closeOpenedBranch();

                //open content 
                if (filename == null || !File.Exists(filename)) return;
                string content = File.ReadAllText(filename);

                //parse data
                loadedBranch = JsonConvert.DeserializeObject<CategoryBranch>(content);

                //load tree
                loadCategoryTree();

                //set others
                selectedFile = filename;
                splitContainer1.Enabled = true;
                catFileLabel.Text = Path.GetFileName(filename);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        //
        // Branch Viewer
        //
        void loadCategoryTree()
        {
            treeView.Nodes.Clear();
            TreeNode tn = getElement(loadedBranch);
            tn.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            tn.ImageKey = tn.SelectedImageKey = ROOT_FOLDER;
            tn.Expand();
            treeView.Nodes.Add(tn);
        }

        TreeNode getElement(CategoryProblem prob)
        {
            TreeNode tn = new TreeNode();
            tn.Text = prob.pnum.ToString();
            tn.ToolTipText = prob.note;
            tn.Tag = prob;
            tn.ImageKey = tn.SelectedImageKey = prob.star ? PROB_STAR : PROB_NORMAL;
            tn.NodeFont = new System.Drawing.Font("Segoe UI", 8.5F);
            return tn;
        }

        TreeNode getElement(CategoryBranch branch)
        {
            TreeNode tn = new TreeNode();
            tn.Text = branch.name;
            tn.ToolTipText = branch.note;
            tn.Tag = branch;
            tn.ImageKey = tn.SelectedImageKey = BRANCH_FOLDER;
            tn.NodeFont = new System.Drawing.Font("Segoe UI", 9F);

            //load problems
            if (branch.problems != null)
            {
                TreeNode prob = tn.Nodes.Add("Problems");
                prob.Tag = branch.problems;
                prob.ImageKey = prob.SelectedImageKey = PROB_FOLDER;
                prob.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
                foreach (CategoryProblem p in branch.problems)
                {
                    prob.Nodes.Add(getElement(p));
                }
            }

            //load branches
            if (branch.branches != null)
            {
                TreeNode other = tn.Nodes.Add("Branches");
                other.Tag = branch.branches;
                other.ImageKey = other.SelectedImageKey = BRANCH_LIST;
                other.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
                foreach (CategoryBranch p in branch.branches)
                {
                    other.Nodes.Add(getElement(p));
                }
            }

            return tn;
        }

        //
        // Branch Editor
        // 

        void loadEditorData(TreeNode tnode)
        {
            try
            {
                // clear previous data
                closeEditing();

                //check validity
                if (tnode.Tag == null)
                    return;

                // Get the node with category branch tag
                if (tnode.Tag.GetType() == typeof(List<CategoryBranch>)
                    || tnode.Tag.GetType() == typeof(List<CategoryProblem>))
                {
                    tnode = tnode.Parent;
                }
                else if (tnode.Tag.GetType() != typeof(CategoryBranch))
                {
                    return;
                }

                var curCat = (CategoryBranch)tnode.Tag;
                catnameBox.Text = curCat.name;
                catnoteBox.Text = curCat.note;
                loadProblemList(curCat.problems);
                loadBranchList(curCat.branches);

                //set the current node
                currentNode = tnode;
                splitContainer1.Panel2.Enabled = true;

                //show back button
                pathLabel.Text = tnode.FullPath.Replace("\\Branches", "");
                backTableLayout.ColumnStyles[0].Width = (tnode.Level == 0) ? 0 : 100;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        void loadProblemList(List<CategoryProblem> problems)
        {
            //clear previous items
            problemList.Items.Clear();
            //add all new items
            if (problems == null) return;
            foreach (CategoryProblem p in problems)
            {
                problemList.Items.Add(getProblemListitem(p));
            }
        }

        void loadBranchList(List<CategoryBranch> branches)
        {
            //clear previous items
            branchList.Items.Clear();
            //add all new items
            if (branches == null) return;
            foreach (CategoryBranch b in branches)
            {
                branchList.Items.Add(getBranchListItem(b));
            }
        }

        ListViewItem getProblemListitem(CategoryProblem p)
        {
            ListViewItem lvi = new ListViewItem(p.pnum.ToString());
            lvi.SubItems.Add(p.star.ToString());
            lvi.SubItems.Add(p.note);
            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems[1].ForeColor = Color.Red;
            lvi.SubItems[2].ForeColor = Color.DimGray;
            lvi.Tag = p;
            return lvi;
        }

        ListViewItem getBranchListItem(CategoryBranch b)
        {
            ListViewItem lvi = new ListViewItem(b.name);
            lvi.SubItems.Add(b.note);
            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems[1].ForeColor = Color.DimGray;
            lvi.Tag = b;
            return lvi;
        }

        #endregion

        #region Other methods

        //
        // Save methods
        //
        void saveIndex()
        {
            try
            {
                string path = indexFolder();
                if (!Directory.Exists(path)) return;

                List<string> data = new List<string>();
                var arr = Directory.GetFiles(path, "*" + EXTENSION);
                foreach (string v in arr)
                {
                    data.Add(Path.GetFileName(v));
                }

                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(indexBox.Text, json);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        void saveOpenedBranch()
        {
            if (string.IsNullOrEmpty(selectedFile)
                || !File.Exists(selectedFile)
                || branchList == null)
            {
                return;
            }

            try
            {
                string json = JsonConvert.SerializeObject(loadedBranch, Formatting.Indented);
                File.WriteAllText(selectedFile, json);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        //
        // Close methods
        //
        void closeOpenedBranch()
        {
            closeEditing();
            selectedFile = null;
            loadedBranch = null;
            treeView.Nodes.Clear();
            splitContainer1.Enabled = false;
            catFileLabel.Text = "No Opened Category";
        }

        void closeEditing()
        {
            currentNode = null;
            pathLabel.Text = "...";
            catnameBox.Clear();
            catnoteBox.Clear();
            problemList.Items.Clear();
            branchList.Items.Clear();
            backTableLayout.ColumnStyles[0].Width = 0;
            splitContainer1.Panel2.Enabled = false;
        }

        //
        // Delete methods
        //
        void deleteNode(TreeNode tn)
        {
            if (tn.Tag == null || tn.Level == 0) return;

            if (tn.Tag.GetType() == typeof(CategoryBranch))
            {
                // show confirm diaglog
                if (MessageBox.Show("Are you sure to remove this branch and all of its contents?", this.Text,
                       MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                if (currentNode == tn) closeEditing();
                var par = (List<CategoryBranch>)tn.Parent.Tag;
                par.Remove((CategoryBranch)tn.Tag);
            }
            else if (tn.Tag.GetType() == typeof(CategoryProblem))
            {
                var par = (List<CategoryProblem>)tn.Parent.Tag;
                par.Remove((CategoryProblem)tn.Tag);
            }
            else
            {
                return;
            }

            //remove from view
            tn.Remove();
        }


        #endregion

        //
        // Event Methods
        //
        #region Various event methods

        private void browseButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "INDEX|INDEX";
            ofd.FileName = "INDEX";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                indexBox.Text = ofd.FileName;
            }
        }

        private void indexBox_TextChanged(object sender, System.EventArgs e)
        {
            loadCategoryList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveOpenedBranch();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            loadCategoryBranch(selectedFile);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentNode.Level >= 2)
            {
                loadEditorData(currentNode.Parent.Parent);
            }
        }

        #endregion

        #region Category File List

        private void addButton_Click(object sender, System.EventArgs e)
        {
            string name = filenameBox.Text;
            if (!isValidFile(name))
            {
                MessageBox.Show("Filename is not valid");
                return;
            }

            string fullname = Path.Combine(indexFolder(), name);
            if (!fullname.EndsWith(EXTENSION))
                fullname += EXTENSION;

            string json = JsonConvert.SerializeObject(new CategoryBranch(name), Formatting.Indented);
            File.WriteAllText(fullname, json);

            fileList.Items.Add(getFileListItem(fullname));
            fileList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            fileList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            filenameBox.Clear();
            saveIndex();
        }

        private void fileList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            e.CancelEdit = true;
            if (!isValidFile(e.Label))
            {
                return;
            }

            string old = fileList.Items[e.Item].SubItems[1].Text;
            string path = Path.Combine(Path.GetDirectoryName(old), e.Label);
            if (!path.EndsWith(EXTENSION))
                path += EXTENSION;

            if (File.Exists(path))
            {
                MessageBox.Show("Another file exists with same name");
                return;
            }

            //rename
            File.Move(old, path);
            fileList.Items[e.Item].SubItems[1].Text = path;
            fileList.Items[e.Item].SubItems[0].Text = Path.GetFileName(path);

            //save data
            saveIndex();
        }

        private void filenameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.PerformClick();
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = (fileList.SelectedItems.Count != 0);
            //enable edit buttons
            editListButton.Enabled = sel;
            deleteListButton.Enabled = sel;

            //display category
            if (sel)
            {
                loadCategoryBranch(fileList.FocusedItem.SubItems[1].Text);
            }
            else
            {
                saveOpenedBranch();
                closeOpenedBranch();
            }
        }

        private void editListButton_Click(object sender, EventArgs e)
        {
            if (fileList.FocusedItem == null) return;
            fileList.FocusedItem.BeginEdit();
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileList.FocusedItem == null) return;

                // check if user is sure
                string text = fileList.FocusedItem.SubItems[0].Text;
                if (MessageBox.Show("Are you sure to permanently delete " + text, this.Text,
                        MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                // delete
                string path = fileList.FocusedItem.SubItems[1].Text;
                if (selectedFile == path) closeOpenedBranch();
                File.Delete(path);
                fileList.FocusedItem.Remove();

                //save data
                saveIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the list.");
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void fileList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                editListButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteListButton.PerformClick();
            }
        }

        #endregion

        #region tree view

        private void treeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                reloadTreeButton.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                editTreeButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteTreeButton.PerformClick();
            }
        }

        private void reloadTreeButton_Click(object sender, EventArgs e)
        {
            loadCategoryTree();
        }

        private void editTreeButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null) return;
            //show editor
            TreeNode tn = treeView.SelectedNode;
            Object tag = treeView.SelectedNode.Tag;
            if (tag == null) return;

            if (tag.GetType() == typeof(CategoryProblem)) //problem info
            {
                var pe = new ProblemEditor((CategoryProblem)tag);
                if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tn.Text = pe.Problem.pnum.ToString();
                    tn.Tag = pe.Problem.note;
                    tn.ImageKey = tn.SelectedImageKey = pe.Problem.star ? PROB_STAR : PROB_NORMAL;
                }
            }
            else if (tag.GetType() == typeof(CategoryBranch)) //branch info
            {
                var be = new BranchEditor((CategoryBranch)tag);
                if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tn.Text = be.Branch.name;
                    tn.Tag = be.Branch.note;
                }
            }
        }

        private void deleteTreeButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null) return;

            //delete selected node
            deleteNode(treeView.SelectedNode);

            //save data
            saveOpenedBranch();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool sel = (treeView.SelectedNode != null);
            editTreeButton.Enabled = sel;
            deleteTreeButton.Enabled = sel;

            //load editor data
            loadEditorData(treeView.SelectedNode);
        }

        #endregion

        #region Branch Editor

        private void catnameBox_TextChanged(object sender, EventArgs e)
        {
            if (currentNode == null) return;
            if (string.IsNullOrEmpty(catnameBox.Text)) return;
            ((CategoryBranch)currentNode.Tag).name = catnameBox.Text;
        }

        private void catnoteBox_TextChanged(object sender, EventArgs e)
        {
            if (currentNode == null) return;
            ((CategoryBranch)currentNode.Tag).note = catnoteBox.Text;
        }

        //
        // Add problem button
        //
        private void addProbButton_Click(object sender, EventArgs e)
        {
            ProblemEditor pe = new ProblemEditor();
            if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var cur = (CategoryBranch)currentNode.Tag;
                if (cur.hasProblem(pe.Problem.pnum))
                {
                    MessageBox.Show("Problem number is already on the list.");
                    return;
                }
                if (cur.problems == null)
                    cur.problems = new List<CategoryProblem>();
                cur.problems.Add(pe.Problem);
                problemList.Items.Add(getProblemListitem(pe.Problem));
            }
        }

        private void problemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = (problemList.SelectedItems.Count != 0);
            editProbButton.Enabled = sel;
            deleteProbButton.Enabled = sel;
        }


        private void problemList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadProblemList(((CategoryBranch)currentNode.Tag).problems);
            }
            else if (e.KeyCode == Keys.F2)
            {
                editProbButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteProbButton.PerformClick();
            }
        }

        private void editProbButton_Click(object sender, EventArgs e)
        {
            if (problemList.FocusedItem == null) return;
            ProblemEditor pe = new ProblemEditor((CategoryProblem)problemList.FocusedItem.Tag);
            if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                problemList.FocusedItem.Text = pe.Problem.pnum.ToString();
                problemList.FocusedItem.SubItems[1].Text = pe.Problem.star.ToString();
                problemList.FocusedItem.SubItems[2].Text = pe.Problem.note;
            }
        }

        private void deleteProbButton_Click(object sender, EventArgs e)
        {
            if (problemList.FocusedItem == null) return;
            var p = (CategoryProblem)problemList.FocusedItem.Tag;

            //confirm
            if (MessageBox.Show("Are you sure to remove " + p.pnum.ToString() + "?", this.Text,
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //delete
            var cur = (CategoryBranch)currentNode.Tag;
            cur.problems.Remove(p);
        }

        //
        // Branch list
        // 
        private void addBranchButton_Click(object sender, EventArgs e)
        {
            BranchEditor be = new BranchEditor();
            if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var cur = (CategoryBranch)currentNode.Tag;
                if (cur.hasBranch(be.Branch.name))
                {
                    MessageBox.Show("Another branch with same name is already on the list.");
                    return;
                }
                if (cur.branches == null)
                    cur.branches = new List<CategoryBranch>();
                cur.branches.Add(be.Branch);
                //add to list 
                branchList.Items.Add(getBranchListItem(be.Branch));
            }
        }

        private void branchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = (branchList.SelectedItems.Count != 0);
            editBranchButton.Enabled = sel;
            deleteBranchButton.Enabled = sel;
        }

        private void branchList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadBranchList(((CategoryBranch)currentNode.Tag).branches);
            }
            else if (e.KeyCode == Keys.F2)
            {
                editBranchButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteBranchButton.PerformClick();
            }
        }

        private void editBranchButton_Click(object sender, EventArgs e)
        {
            if (branchList.FocusedItem == null) return;
            BranchEditor be = new BranchEditor((CategoryBranch)branchList.FocusedItem.Tag);
            if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                branchList.FocusedItem.Text = be.Branch.name;
                branchList.FocusedItem.SubItems[1].Text = be.Branch.note;
            }
        }

        private void deleteBranchButton_Click(object sender, EventArgs e)
        {
            if (branchList.FocusedItem == null) return;
            var b = (CategoryBranch)branchList.FocusedItem.Tag;

            //confirm
            if (MessageBox.Show("Are you sure to remove " + b.name + "?", this.Text,
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //delete
            var cur = (CategoryBranch)currentNode.Tag;
            cur.branches.Remove(b);
        }

        #endregion


    }
}
