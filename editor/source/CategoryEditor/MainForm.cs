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
         
        TreeNode selectedNode = null;
        CategoryNode selectedBranch = null;
        CategoryIndex selectedIndex = null;
        List<CategoryIndex> allIndex = null;
        bool branchEdited = false;

        public MainForm()
        {
            InitializeComponent();

            //load default state 
            closeEditing();
            closeOpenedBranch();
            loadCategoryList();
            this.WindowState = Properties.Settings.Default.LastWinState;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);            
            saveOpenedBranch();
            saveIndex();
        }

        //
        // My Functions
        //
        #region Basic functions

        public static string indexFolder()
        {
            return Path.GetDirectoryName(Properties.Settings.Default.INDEX);
        }

        public static string getCategoryFile(CategoryIndex ci)
        {
            return Path.Combine(indexFolder(), ci.file);
        }

        public static bool isValidFile(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                return false;

            char[] invalid = Path.GetInvalidFileNameChars();
            if (filename.IndexOfAny(invalid) >= 0)
                return false;

            return true;
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
                selectedIndex = null;

                string content = File.ReadAllText(indexBox.Text);
                allIndex = JsonConvert.DeserializeObject<List<CategoryIndex>>(content);

                fileList.Items.Clear();
                foreach (var v in allIndex)
                {
                    fileList.Items.Add(getFileListItem(v));
                }

                panel1.Enabled = true;
                fileList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent); 
            }
            catch (Exception ex)
            {
                closeOpenedBranch();
                panel1.Enabled = false;
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        ListViewItem getFileListItem(CategoryIndex ci)
        {
            ListViewItem lvi = new ListViewItem(Path.GetFileName(ci.file));
            lvi.Name = "file";
            lvi.SubItems.Add(ci.ver.ToString());
            lvi.Tag = ci;
            lvi.ImageKey = BIG_FOLDER;
            return lvi;
        }

        //
        // Category Branch
        //
        void loadCategoryBranch(CategoryIndex catIndx)
        {
            try
            {
                if (selectedIndex == catIndx) return;

                //first close previous branch
                closeOpenedBranch();

                //open content 
                string filename = getCategoryFile(catIndx);
                if (filename == null || !File.Exists(filename)) return;
                string content = File.ReadAllText(filename);

                //parse data
                selectedBranch = JsonConvert.DeserializeObject<CategoryNode>(content);

                //load tree
                loadCategoryTree();

                //set others
                selectedIndex = catIndx;
                splitContainer1.Enabled = true;
                catFileLabel.Text = string.Format("{0} : Version {1}", catIndx.file, catIndx.ver);
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
            TreeNode tn = getElement(selectedBranch);
            tn.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            tn.ImageKey = tn.SelectedImageKey = ROOT_FOLDER;
            tn.Expand();
            treeView.Nodes.Add(tn);
        }

        TreeNode getElement(CategoryProblem prob)
        {
            TreeNode tn = new TreeNode();
            tn.Name = "problem";
            tn.Text = prob.pnum.ToString();
            tn.ToolTipText = prob.note;
            tn.Tag = prob;
            tn.ImageKey = tn.SelectedImageKey = prob.star ? PROB_STAR : PROB_NORMAL;
            tn.NodeFont = new System.Drawing.Font("Segoe UI", 8.5F);
            return tn;
        }

        TreeNode getElement(CategoryNode branch)
        {
            TreeNode tn = new TreeNode();
            tn.Name = "branch";
            tn.Text = branch.name;
            tn.ToolTipText = branch.note;
            tn.Tag = branch;
            tn.ImageKey = tn.SelectedImageKey = BRANCH_FOLDER;
            tn.NodeFont = new System.Drawing.Font("Segoe UI", 9F);

            //load problems
            if (branch.problems != null)
            {
                TreeNode prob = tn.Nodes.Add("Problems");
                prob.Name = "p";
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
                other.Name = "b";
                other.Tag = branch.branches;
                other.ImageKey = other.SelectedImageKey = BRANCH_LIST;
                other.NodeFont = new System.Drawing.Font("Segoe UI", 9F);
                foreach (CategoryNode p in branch.branches)
                {
                    other.Nodes.Add(getElement(p));
                }
                other.Expand();
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
                //check validity
                if (tnode == null || tnode.Tag == null)
                {
                    closeEditing();
                    return;
                }

                // Get the node with category branch tag
                if (tnode.Tag.GetType() == typeof(List<CategoryNode>)
                    || tnode.Tag.GetType() == typeof(List<CategoryProblem>))
                {
                    tnode = tnode.Parent;
                }
                else if (tnode.Tag.GetType() != typeof(CategoryNode))
                {
                    closeEditing();
                    return;
                }
                
                //check if this is already opened
                if (selectedNode == tnode) return;

                //close previously opened node
                closeEditing();

                var curCat = (CategoryNode)tnode.Tag;
                catnameBox.Text = curCat.name;
                catnoteBox.Text = curCat.note;
                loadProblemList(curCat.problems);
                loadBranchList(curCat.branches);

                //set the current node
                selectedNode = tnode;
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

        void loadBranchList(List<CategoryNode> branches)
        {
            //clear previous items
            branchList.Items.Clear();
            //add all new items
            if (branches == null) return;
            foreach (CategoryNode b in branches)
            {
                branchList.Items.Add(getBranchListItem(b));
            }
        }

        ListViewItem getProblemListitem(CategoryProblem p)
        {
            ListViewItem lvi = new ListViewItem(p.pnum.ToString());
            lvi.Name = "problem";
            lvi.SubItems.Add(p.star.ToString());
            lvi.SubItems.Add(p.note);
            lvi.UseItemStyleForSubItems = false;
            lvi.SubItems[1].ForeColor = Color.Red;
            lvi.SubItems[2].ForeColor = Color.DimGray;
            lvi.Tag = p;
            return lvi;
        }

        ListViewItem getBranchListItem(CategoryNode b)
        {
            ListViewItem lvi = new ListViewItem(b.name);
            lvi.Name = "branch";
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

                string json = JsonConvert.SerializeObject(allIndex, Formatting.Indented);
                File.WriteAllText(indexBox.Text, json);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        void saveOpenedBranch()
        {
            if (selectedIndex == null || selectedBranch == null)
            {
                return;
            }

            try
            {
                string json = JsonConvert.SerializeObject(selectedBranch, Formatting.Indented);                
                File.WriteAllText(getCategoryFile(selectedIndex), json);                 
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
            selectedIndex = null;
            selectedBranch = null;
            treeView.Nodes.Clear();
            splitContainer1.Enabled = false;
            catFileLabel.Text = "No Opened Category";            
            if (branchEdited)
            {
                branchEdited = false;
                selectedIndex.ver++;                
                saveIndex();
            }
        }

        void closeEditing()
        {
            if (branchEdited) saveOpenedBranch();
            selectedNode = null;
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

            if (tn.Tag.GetType() == typeof(CategoryNode))
            {
                // show confirm diaglog
                if (MessageBox.Show("Are you sure to remove this branch and all of its contents?", this.Text,
                       MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                if (selectedNode == tn) closeEditing();
                var par = (List<CategoryNode>)tn.Parent.Tag;
                par.Remove((CategoryNode)tn.Tag);
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastWinState = this.WindowState;
        }

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
            saveIndex();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            loadCategoryBranch(selectedIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (selectedNode.Level >= 2)
            {
                loadEditorData(selectedNode.Parent.Parent);
            }
        }

        #endregion

        #region Category File List
        
        //
        // Add category
        //
        private void filenameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.PerformClick();
            }
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            string name = filenameBox.Text;
            if (!isValidFile(name))
            {
                MessageBox.Show("Filename is not valid");
                return;
            }

            if(!name.EndsWith(EXTENSION)) 
                name += EXTENSION;

            //check if category index already has similar file
            foreach(CategoryIndex v in allIndex)
            {
                if(v.file == name) 
                {
                    MessageBox.Show("Another file exist with same name");
                    return;
                }
            }

            CategoryIndex catInd = new CategoryIndex(name);
            string fullName = getCategoryFile(catInd);
            if (!File.Exists(fullName))
            {                
                string json = JsonConvert.SerializeObject(new CategoryNode(name), Formatting.Indented);
                File.WriteAllText(fullName, json);
            }

            allIndex.Add(catInd);
            fileList.Items.Add(getFileListItem(catInd));
            fileList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            filenameBox.Clear();
            saveIndex();
        }

        //
        // File list events
        //
        private void fileList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                editListButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteListButton.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                loadCategoryList();
            }
        }

        private void fileList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            e.CancelEdit = true;
            if (!isValidFile(e.Label)) return;
            
            var cur = (CategoryIndex)fileList.Items[e.Item].Tag;
            string oldPath = getCategoryFile(cur);

            string newName = e.Label;
            if (!newName.EndsWith(EXTENSION)) 
                newName += EXTENSION;

            if(newName == cur.file) return;

            //check if category index already has similar file            
            foreach (CategoryIndex v in allIndex)
            {
                if (v.file == newName)
                {
                    MessageBox.Show("Another file with same name exist.");
                    return;
                }
            }

            cur.file = newName;
            string newPath = getCategoryFile(cur);
                        
            //rename by moving
            File.Move(oldPath, newPath);

            fileList.Items[e.Item].SubItems[0].Text = cur.file;
            fileList.Items[e.Item].SubItems[1].Text = cur.ver.ToString();
            saveIndex();
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
                var ci = (CategoryIndex)fileList.FocusedItem.Tag;
                fileList.FocusedItem.SubItems[1].Text = ci.ver.ToString();
                loadCategoryBranch(ci);
            }
            else
            {
                closeOpenedBranch();
            }
        }

        //
        // Buttons
        //
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
                var ci = (CategoryIndex)fileList.FocusedItem.Tag;
                if (selectedIndex == ci) closeOpenedBranch();                
                File.Delete(getCategoryFile(ci));
                allIndex.RemoveAt(fileList.FocusedItem.Index);
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

        #endregion

        #region Category Branch Viewer

        //
        // Tree view events
        //
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

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool sel = (treeView.SelectedNode != null);
            editTreeButton.Enabled = sel;
            deleteTreeButton.Enabled = sel;

            //load editor data
            loadEditorData(treeView.SelectedNode);
        }

        //
        // Buttons
        //
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
                    
                    branchEdited = true;
                }
            }
            else if (tag.GetType() == typeof(CategoryNode)) //branch info
            {
                var be = new BranchEditor((CategoryNode)tag);
                if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tn.Text = be.Branch.name;
                    tn.Tag = be.Branch.note;

                    branchEdited = true;
                }
            }
        }

        private void deleteTreeButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null) return;

            //delete selected node
            deleteNode(treeView.SelectedNode);
            
            branchEdited = true;
        }

        #endregion

        #region Branch Editor

        //
        // Category name and notes
        //
        private void catnameBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedNode == null) return;
            if (string.IsNullOrEmpty(catnameBox.Text)) return;
            ((CategoryNode)selectedNode.Tag).name = catnameBox.Text;
            selectedNode.Text = catnameBox.Text;

            branchEdited = true;
        }

        private void catnoteBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedNode == null) return;
            ((CategoryNode)selectedNode.Tag).note = catnoteBox.Text;
            selectedNode.ToolTipText = catnoteBox.Text;

            branchEdited = true;
        }

        //
        // Add problem button
        //

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
                loadProblemList(((CategoryNode)selectedNode.Tag).problems);
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

        private void addProbButton_Click(object sender, EventArgs e)
        {
            ProblemEditor pe = new ProblemEditor();
            if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var cur = (CategoryNode)selectedNode.Tag;
                if (cur.hasProblem(pe.Problem.pnum))
                {
                    MessageBox.Show("Problem number is already on the list.");
                    return;
                }
                if (cur.problems == null)
                    cur.problems = new List<CategoryProblem>();
                cur.problems.Add(pe.Problem);

                //add to list
                problemList.Items.Add(getProblemListitem(pe.Problem));
                selectedNode.Nodes["p"].Nodes.Add(getElement(pe.Problem));

                branchEdited = true;
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

                branchEdited = true;
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
            try
            {
                var cur = (CategoryNode)selectedNode.Tag;
                cur.problems.Remove(p);
                //delete from list
                selectedNode.Nodes["p"].Nodes.RemoveAt(problemList.FocusedItem.Index);
                problemList.FocusedItem.Remove();

                branchEdited = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        //
        // Branch list
        // 

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
                loadBranchList(((CategoryNode)selectedNode.Tag).branches);
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

        private void addBranchButton_Click(object sender, EventArgs e)
        {
            BranchEditor be = new BranchEditor();
            if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var cur = (CategoryNode)selectedNode.Tag;
                if (cur.hasBranch(be.Branch.name))
                {
                    MessageBox.Show("Another branch with same name is already on the list.");
                    return;
                }

                if (cur.branches == null)
                    cur.branches = new List<CategoryNode>();
                cur.branches.Add(be.Branch);

                //add to list 
                branchList.Items.Add(getBranchListItem(be.Branch));
                selectedNode.Nodes["b"].Nodes.Add(getElement(be.Branch));

                branchEdited = true;
            }
        }

        private void editBranchButton_Click(object sender, EventArgs e)
        {
            if (branchList.FocusedItem == null) return;
            try
            {
                var p = selectedNode.Nodes["b"].Nodes[branchList.FocusedItem.Index];
                treeView.SelectedNode = p;
                p.Expand();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void deleteBranchButton_Click(object sender, EventArgs e)
        {
            if (branchList.FocusedItem == null) return;
            var b = (CategoryNode)branchList.FocusedItem.Tag;

            //confirm
            if (MessageBox.Show("Are you sure to remove \"" + b.name + "\"?", this.Text,
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //delete
            //try
            {
                var cur = (CategoryNode)selectedNode.Tag;
                cur.branches.Remove(b);
                //delete from lists
                selectedNode.Nodes["b"].Nodes.RemoveAt(branchList.FocusedItem.Index);
                branchList.FocusedItem.Remove();

                branchEdited = true;
            }
           // catch (Exception ex)
            {
               // Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        #endregion
        
    }
}
