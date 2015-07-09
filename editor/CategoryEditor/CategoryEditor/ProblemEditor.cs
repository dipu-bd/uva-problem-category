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
        public ProblemEditor(CategoryProblem prob = null)
        {
            InitializeComponent();
            if (prob == null)
            {
                this.Text = "Add Problem";
                okButton.Text = "Add";
                prob = new CategoryProblem();
            }

            Problem = prob;
            numberTextBox.Text = prob.pnum.ToString();
            noteTextBox.Text = prob.note;
            starCombo.SelectedIndex = prob.star ? 1 : 0;
        }
                
        public CategoryProblem Problem { get; set; }

        private void starCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Problem.star = (starCombo.SelectedIndex == 1);
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            int res = Problem.pnum;
            int.TryParse(numberTextBox.Text, out res);
            Problem.pnum = res;
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            Problem.note = noteTextBox.Text;
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
    }
}
