using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CategoryEditor
{
    public partial class ProblemEditor : Form
    {
        public ProblemEditor(CategoryNode nod)
        {
            InitializeComponent();

            this.node = nod;

            numberVal.Focus();
            numberVal.Value = 100;
            noteTextBox.Text = "";
            starCombo.SelectedIndex = 0;
        }

        private CategoryNode node;

        bool addProblem()
        {
            int pnum = (int)numberVal.Value;
            if (node.hasProblem(pnum))
            {
                MessageBox.Show("Problem number is already on the list.");
                return false;
            }

            CategoryProblem problem = new CategoryProblem(pnum);
            problem.note = noteTextBox.Text.Trim();
            problem.star = (starCombo.SelectedIndex == 1);
            return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(!addProblem()) return;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            if (!addProblem()) return;
            numberVal.Focus();
            starCombo.SelectedIndex = 0;
            noteTextBox.Text = "";
        }

        private void numberVal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addNewButton.PerformClick();
            }
        }


    }
}
