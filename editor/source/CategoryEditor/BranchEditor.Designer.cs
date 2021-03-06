﻿namespace CategoryEditor
{
    partial class BranchEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nodeListView = new BrightIdeasSoftware.FastObjectListView();
            this.nameCat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.nodeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(16, 80);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noteTextBox.Size = new System.Drawing.Size(206, 81);
            this.noteTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(372, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(266, 168);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(135, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(16, 35);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(206, 23);
            this.nameBox.TabIndex = 1;
            this.nameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "On the list:";
            // 
            // nodeListView
            // 
            this.nodeListView.AllColumns.Add(this.nameCat);
            this.nodeListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.nodeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCat});
            this.nodeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.nodeListView.EmptyListMsg = "";
            this.nodeListView.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeListView.FullRowSelect = true;
            this.nodeListView.HideSelection = false;
            this.nodeListView.Location = new System.Drawing.Point(239, 35);
            this.nodeListView.Name = "nodeListView";
            this.nodeListView.ShowGroups = false;
            this.nodeListView.ShowItemToolTips = true;
            this.nodeListView.Size = new System.Drawing.Size(233, 126);
            this.nodeListView.TabIndex = 19;
            this.nodeListView.UseCellFormatEvents = true;
            this.nodeListView.UseCompatibleStateImageBehavior = false;
            this.nodeListView.UseCustomSelectionColors = true;
            this.nodeListView.UseHotItem = true;
            this.nodeListView.UseTranslucentHotItem = true;
            this.nodeListView.UseTranslucentSelection = true;
            this.nodeListView.View = System.Windows.Forms.View.Details;
            this.nodeListView.VirtualMode = true;
            // 
            // nameCat
            // 
            this.nameCat.AspectName = "name";
            this.nameCat.FillsFreeSpace = true;
            this.nameCat.Text = "Name";
            this.nameCat.Width = 100;
            // 
            // BranchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.nodeListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BranchEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Branch";
            ((System.ComponentModel.ISupportInitialize)(this.nodeListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private BrightIdeasSoftware.FastObjectListView nodeListView;
        private BrightIdeasSoftware.OLVColumn nameCat;
    }
}