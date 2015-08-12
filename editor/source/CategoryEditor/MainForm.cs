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
        Bitmap BIG_FOLDER = Properties.Resources.big;
        Bitmap ROOT_FOLDER = Properties.Resources.root;
        Bitmap BRANCH_LIST = Properties.Resources.blist;
        Bitmap BRANCH_FOLDER = Properties.Resources.bfolder;
        Bitmap PROB_FOLDER = Properties.Resources.pfolder;
        Bitmap PROB_NORMAL = Properties.Resources.pfile;
        Bitmap PROB_STAR = Properties.Resources.pstar;

        List<CategoryIndex> allIndex = null;
        CategoryIndex selectedIndex = null;
        CategoryNode selectedBranch = null;
        CategoryNode editingNode = null;
        bool branchEdited = false;

        public MainForm()
        {
            InitializeComponent();

            //load default state 
            this.WindowState = Properties.Settings.Default.LastWinState;
            setListGetterMethods();

            closeEditing();
            closeOpenedBranch();
            loadCategoryList();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            closeOpenedBranch();
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

        public static string getCategoryFile(string file)
        {
            return Path.Combine(indexFolder(), file);
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

        void setListGetterMethods()
        {
            fileList.FormatCell += delegate(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
            {
                if (e.Column == fileVersionCol)
                {
                    e.SubItem.ForeColor = Color.Blue;
                }
            };

            fileNameCol.ImageGetter = delegate(object data)
            {
                return BIG_FOLDER;
            };

            treeList.CanExpandGetter = delegate(object data)
            {
                return ((CategoryNode)data).branches.Count > 0;
            };

            treeList.ChildrenGetter = delegate(object data)
            {
                return ((CategoryNode)data).branches;
            };

            treeList.CellToolTipGetter = delegate(BrightIdeasSoftware.OLVColumn col, object data)
            {
                return ((CategoryNode)data).note;
            };

            nameTreeCol.ImageGetter = delegate(object data)
            {
                if (data == null) return null;
                if (((CategoryNode)data).isTop())
                    return ROOT_FOLDER;
                else
                    return BRANCH_FOLDER;
            };

            pnumProb.ImageGetter = delegate(object data)
            {
                if (data == null) return null;
                if (((CategoryProblem)data).star)
                    return PROB_STAR;
                else
                    return PROB_NORMAL;
            };
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

                fileList.SetObjects(allIndex);
                panel1.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);

                closeOpenedBranch();
                fileList.ClearObjects();
                panel1.Enabled = false;
            }
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
                string filename = getCategoryFile(catIndx.file);
                if (filename == null || !File.Exists(filename)) return;
                string content = File.ReadAllText(filename);

                //parse data                
                selectedBranch = JsonConvert.DeserializeObject<CategoryNode>(content);
                selectedBranch.updateParent();
                treeList.SetObjects(new CategoryNode[] { selectedBranch });
                treeList.Expand(selectedBranch);
                treeList.SelectObject(selectedBranch);

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
        // Branch Editor
        // 

        void loadEditorData(CategoryNode node)
        {
            try
            {
                //check if this is already opened
                if (editingNode == node) return;

                //close previously opened node
                closeEditing();

                editingNode = node;
                loadBranchWizard();
                loadBranchEditor();

                //set the current node
                pathLabel.Text = node.getPath();
                backTableLayout.ColumnStyles[0].Width = node.isTop() ? 0 : 100;

                tabControl1.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\r\n" + ex.StackTrace);
            }
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

                string json = JsonConvert.SerializeObject(allIndex, Formatting.None);
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
                string json = JsonConvert.SerializeObject(selectedBranch, Formatting.None);
                File.WriteAllText(getCategoryFile(selectedIndex.file), json);
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
            if (branchEdited)
            {
                branchEdited = false;
                selectedIndex.ver++;
                saveIndex();
            }
            selectedIndex = null;
            treeList.ClearObjects();
            splitContainer1.Enabled = false;
            catFileLabel.Text = "No Opened Category";
        }

        void closeEditing()
        {
            if (branchEdited)
            {
                saveEditedData();
                saveOpenedBranch();
            }
            pathLabel.Text = "...";
            catnameBox.Clear();
            catnoteBox.Clear();
            problemListView.SetObjects(null);
            fastColoredTextBox1.Text = "";
            tabControl1.Enabled = false;
            backTableLayout.ColumnStyles[0].Width = 0;
        }

        public bool ConfirmDelete()
        {
            return MessageBox.Show("Are you sure to permanently delete this item?", this.Text,
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;
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
            saveEditedData();
            saveOpenedBranch();
            saveIndex();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (!editingNode.isTop())
            {
                loadEditorData(editingNode.getParent());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == wizardTab)
            {
                saveEditedData(true);
                loadBranchWizard();
            }
            else if (tabControl1.SelectedTab == editorTab)
            {
                loadBranchEditor();
            }
        }

        private void hideCategoryList_Click(object sender, EventArgs e)
        {
            if (hideCategoryList.Text == "<")
            {
                hideCategoryList.Text = ">";
                panel1.Width = 25;
            }
            else
            {
                hideCategoryList.Text = "<";
                panel1.Width = 200;
            }
        }

        private void hideTreeList_Click(object sender, EventArgs e)
        {
            if (hideTreeList.Text == "<")
            {
                hideTreeList.Text = ">";
                splitContainer1.SplitterDistance = 25;
            }
            else
            {
                hideTreeList.Text = "<";
                splitContainer1.SplitterDistance = (int)(2 * splitContainer1.Width / 5);
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

            if (!name.EndsWith(EXTENSION))
                name += EXTENSION;

            //check if category index already has similar file
            foreach (CategoryIndex v in allIndex)
            {
                if (v.file == name)
                {
                    MessageBox.Show("Another file exist with same name");
                    return;
                }
            }

            CategoryIndex catInd = new CategoryIndex(name);
            string fullName = getCategoryFile(catInd.file);
            if (!File.Exists(fullName))
            {
                string json = JsonConvert.SerializeObject(new CategoryNode(name), Formatting.None);
                File.WriteAllText(fullName, json);
            }

            allIndex.Add(catInd);
            fileList.SetObjects(allIndex);

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

        private void fileList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column != fileNameCol) return;

            e.Cancel = true;

            string oldVal = (string)e.Value;
            string newVal = (string)e.NewValue;
            if (!newVal.EndsWith(EXTENSION))
                newVal += EXTENSION;

            if (oldVal == newVal || !isValidFile(newVal)) return;

            //check if category index already has similar file            
            foreach (CategoryIndex v in allIndex)
            {
                if (v.file == newVal)
                {
                    MessageBox.Show("Another file with same name exist.");
                    return;
                }
            }

            //rename by moving
            string oldPath = getCategoryFile(oldVal);
            string newPath = getCategoryFile(newVal);
            File.Move(oldPath, newPath);
            File.Delete(oldPath);

            ((CategoryIndex)e.RowObject).file = newVal;
            saveIndex();

            e.Cancel = false;
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = (fileList.SelectedObject != null);

            //enable edit buttons
            editListButton.Enabled = sel;
            deleteListButton.Enabled = sel;

            //display category
            if (sel)
            {
                loadCategoryBranch((CategoryIndex)fileList.SelectedObject);
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
            if (fileList.SelectedItem == null) return;
            fileList.StartCellEdit(fileList.SelectedItem, 0);
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileList.SelectedItem == null) return;

                // check if user is sure
                if (!ConfirmDelete()) return;

                // delete
                var ci = (CategoryIndex)fileList.SelectedObject;
                if (selectedIndex == ci) closeOpenedBranch();
                File.Delete(getCategoryFile(ci.file));
                allIndex.Remove(ci);
                fileList.SetObjects(allIndex);

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

        #region Category Branch Viewer Tree

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

        private void treeList_SelectionChanged(object sender, EventArgs e)
        {
            bool sel = (treeList.SelectedObject != null);

            editTreeButton.Enabled = sel;
            deleteTreeButton.Enabled = sel;

            //load editor data 
            if (sel && treeList.SelectedObject.GetType() == typeof(CategoryNode))
            {
                loadEditorData((CategoryNode)treeList.SelectedObject);
            }
            else
            {
                closeEditing();
            }
        }

        private void treeList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (!e.Value.Equals(e.NewValue))
                branchEdited = true;
        }

        //
        // Buttons
        //
        private void reloadTreeButton_Click(object sender, EventArgs e)
        {
            treeList.SetObjects(new CategoryNode[] { selectedBranch }, true);
        }

        private void editTreeButton_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedObject == null) return;
            BranchEditor be = new BranchEditor((CategoryNode)treeList.SelectedObject);
            if (be.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveOpenedBranch();
                reloadTreeButton.PerformClick();
            }
        }

        private void deleteTreeButton_Click(object sender, EventArgs e)
        {
            if (treeList.SelectedObject == null) return;

            //delete selected node            
            ((CategoryNode)treeList.SelectedObject).remove();
            branchEdited = true;

            //refresh tree
            reloadTreeButton.PerformClick();
            saveOpenedBranch();
        }

        //Contex Menu

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeList.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeList.CollapseAll();
        }

        #endregion

        #region Branch Editor Wizard

        void loadBranchWizard()
        {
            catnameBox.Text = editingNode.name;
            catnoteBox.Text = editingNode.note;
            problemListView.SetObjects(editingNode.problems);
        }

        //
        // Category name and notes
        //
        private void catnameBox_TextChanged(object sender, EventArgs e)
        {
            if (editingNode == null) return;
            string txt = catnameBox.Text.Trim();
            if (string.IsNullOrEmpty(txt)) return;
            if (editingNode.name != txt)
            {
                editingNode.name = txt;
                treeList.RefreshObject(editingNode);
                branchEdited = true;
            }
        }

        private void catnoteBox_TextChanged(object sender, EventArgs e)
        {
            if (editingNode == null) return;
            string txt = catnoteBox.Text.Trim();
            if (string.IsNullOrEmpty(txt)) return;
            if (editingNode.note != txt)
            {
                editingNode.note = txt;
                treeList.RefreshObject(editingNode);
                branchEdited = true;
            }
        }

        //
        // Add problem button
        //

        private void problemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = (problemListView.SelectedObject != null);
            editProbButton.Enabled = sel;
            deleteProbButton.Enabled = sel;
        }

        private void problemList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                problemListView.SetObjects(editingNode.problems);
            }
            else if (e.KeyCode == Keys.F2)
            {
                editProbButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteProbButton.PerformClick();
            }
            else if (e.KeyCode == Keys.N && e.Control)
            {
                addProbButton.PerformClick();
            }
        }

        private void problemListView_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (!e.NewValue.Equals(e.Value))
            {
                branchEdited = true;
                problemListView.Focus();
            }
        }

        private void addBatch_Click(object sender, EventArgs e)
        {
            ProblemBatch pe = new ProblemBatch(editingNode);
            if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                branchEdited = true;
                saveOpenedBranch();
                int last = problemListView.GetItemCount();
                problemListView.SetObjects(editingNode.problems);
                if (problemListView.GetItemCount() > 0)
                {
                    problemListView.EnsureVisible(last);
                    problemListView.StartCellEdit(problemListView.GetItem(last), 0);
                }
            }
        }

        private void addCSVButton_Click(object sender, EventArgs e)
        {
            ProblemCSV pe = new ProblemCSV(editingNode);
            if (pe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                branchEdited = true;    
                saveOpenedBranch();
                problemListView.SetObjects(editingNode.problems);         
            }
        }

        private void addProbButton_Click(object sender, EventArgs e)
        {
            try
            {
                branchEdited = true;    
                CategoryProblem cp = new CategoryProblem();
                cp.setParent(editingNode);
                editingNode.problems.Add(cp);
                problemListView.SetObjects(editingNode.problems);
                int last = problemListView.GetItemCount() - 1;
                problemListView.EnsureVisible(last);
                problemListView.StartCellEdit(problemListView.GetItem(last), 0);
            }
            catch (Exception ex)
            {
                Console.Write("Error : " + ex.Message);
            }
        }

        private void editProbButton_Click(object sender, EventArgs e)
        {
            if (problemListView.SelectedItem == null) return;
            problemListView.SelectedItem.BeginEdit();
        }

        private void deleteProbButton_Click(object sender, EventArgs e)
        {
            if (problemListView.SelectedObject == null) return;
            var p = (CategoryProblem)problemListView.SelectedObject;

            //confirm
            if (ConfirmDelete())
            {
                p.remove();
                problemListView.SetObjects(editingNode.problems);
                branchEdited = true;
            }
        }

        #endregion

        #region Branch Editor Box

        void loadBranchEditor()
        {
            fastColoredTextBox1.Text = JsonConvert.SerializeObject(editingNode, Formatting.Indented);
            fastColoredTextBox1.ClearUndo();
        }

        void saveEditedData(bool forced = false)
        {
            if (tabControl1.SelectedTab != editorTab && !forced)
            {
                return;
            }

            try
            {
                string json = fastColoredTextBox1.Text;

                //check if anything was edited
                string original = JsonConvert.SerializeObject(editingNode)
                    .Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");
                string current = json
                    .Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");
                if (original == current)
                    return;

                //save edits
                var node = JsonConvert.DeserializeObject<CategoryNode>(json);
                editingNode.problems = node.problems;
                editingNode.branches = node.branches;
                editingNode.updateParent();
                branchEdited = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when tried to set edited node : " + ex.Message);
            }
        }

        #endregion


    }
}
