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
        public BranchEditor(CategoryNode branch = null)
        {
            InitializeComponent();

            if(branch == null)
            {
                this.Text = "Add Branch";
                okButton.Text = "Add";
                branch = new CategoryNode("New Branch");
            }

            Branch = branch;
            nameBox.Text = branch.name;
            noteTextBox.Text = branch.note;
        }

        public CategoryNode Branch { get; set; }

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

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            Branch.name = nameBox.Text;
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            Branch.note = noteTextBox.Text;
        }
    }
}
