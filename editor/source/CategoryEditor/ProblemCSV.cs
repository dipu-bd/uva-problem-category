using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CategoryEditor
{
    public partial class ProblemCSV : Form
    {
        public ProblemCSV(CategoryNode editingNode)
        {
            InitializeComponent();

            node = editingNode;
        }

        private CategoryNode node;

        private bool AddAll()
        {
            string probs = "";
            foreach(string line in fastColoredTextBox1.Lines)
            {                
                if (string.IsNullOrEmpty(line.Trim())) continue;
                string[] other = line.Trim().Split(',');
                
                int pnum;
                if (!int.TryParse(other[0], out pnum))
                {
                    probs += line + "\n";
                    continue;
                }

                CategoryProblem cp = new CategoryProblem(pnum);
                if (other.Length > 1)
                {
                    cp.star = other[1] == "0" ? false : true;
                }
                if(other.Length > 2)
                {
                    cp.note = other[2];
                }

                if(!node.hasProblem(pnum)) //check if exist before adding
                {
                    node.problems.Add(cp);
                }
                else
                {
                    probs += line + ", [info: alrady exist]\n";
                }
            }
            fastColoredTextBox1.Text = probs;
            return (probs.Length == 0);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "file.csv";
            ofd.Filter = "CSV Files|*.*";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fastColoredTextBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(AddAll())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some of the problems could not be added.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }

}
