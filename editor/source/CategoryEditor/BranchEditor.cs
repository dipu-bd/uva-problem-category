using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CategoryEditor
{
    public partial class BranchEditor : Form
    {
        public BranchEditor(CategoryNode root)
        {
            InitializeComponent();
            
            this.root = root;
            nameBox.Focus();
            nodeListView.SetObjects(root.branches);
        }

        private CategoryNode root;

        bool addBranch()
        {
            string name = nameBox.Text.Trim();
            string note = noteTextBox.Text.Trim();
            
            if(string.IsNullOrEmpty(name)) return false;
            if(root.hasBranch(name))
            {
                MessageBox.Show("Another branch with same name exist.");
                return false;
            }

            root.branches.Add(new CategoryNode(name, note, root));
            nodeListView.SetObjects(root.branches);
            nodeListView.EnsureVisible(root.branches.Count - 1);

            return true;
        }               

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }        

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (addBranch())
            {
                nameBox.Text = "";
                noteTextBox.Text = "";
                nameBox.Focus();
            }
        }

        private void nameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
