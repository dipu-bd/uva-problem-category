namespace CategoryEditor
{
    partial class ProblemEditor
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start1 = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stop1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(18, 122);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Add";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Star Number :";
            // 
            // start1
            // 
            this.start1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start1.Location = new System.Drawing.Point(104, 19);
            this.start1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.start1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(117, 23);
            this.start1.TabIndex = 1;
            this.start1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.start1.ValueChanged += new System.EventHandler(this.start1_ValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(141, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stop1
            // 
            this.stop1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop1.Location = new System.Drawing.Point(104, 48);
            this.stop1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stop1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(117, 23);
            this.stop1.TabIndex = 3;
            this.stop1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Number :";
            // 
            // step1
            // 
            this.step1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1.Location = new System.Drawing.Point(104, 77);
            this.step1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.step1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(117, 23);
            this.step1.TabIndex = 5;
            this.step1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Step Size :";
            // 
            // ProblemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 162);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stop1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProblemEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Problem";
            ((System.ComponentModel.ISupportInitialize)(this.start1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown start1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown stop1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown step1;
        private System.Windows.Forms.Label label2;
    }
}