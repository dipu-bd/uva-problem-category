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
        }

        private CategoryNode node;

        void addProblem()
        {
            if (node.problems == null) return; 
            int start = (int)start1.Value;
            int stop = (int)stop1.Value;
            int step = (int)step1.Value;
            for (int i = start; i <= stop; i += step)
            {
                var v = new CategoryProblem(i);
                v.setParent(node);
                node.problems.Add(v);
            }
        }

        private void start1_ValueChanged(object sender, EventArgs e)
        {
            stop1.Minimum = start1.Value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            addProblem();
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
