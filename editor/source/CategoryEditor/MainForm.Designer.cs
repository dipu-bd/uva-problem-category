namespace CategoryEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editTreeButton = new System.Windows.Forms.Button();
            this.deleteTreeButton = new System.Windows.Forms.Button();
            this.reloadTreeButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.catFileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteBranchButton = new System.Windows.Forms.Button();
            this.addBranchButton = new System.Windows.Forms.Button();
            this.editBranchButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteProbButton = new System.Windows.Forms.Button();
            this.editProbButton = new System.Windows.Forms.Button();
            this.addProbButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catnameBox = new System.Windows.Forms.TextBox();
            this.catnoteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.problemList = new System.Windows.Forms.ListView();
            this.NumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StarCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.branchList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.backTableLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.indexBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(792, 6);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(114, 28);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // indexBox
            // 
            this.indexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.indexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CategoryEditor.Properties.Settings.Default, "INDEX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.indexBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBox.Location = new System.Drawing.Point(108, 8);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(678, 24);
            this.indexBox.TabIndex = 2;
            this.indexBox.Text = global::CategoryEditor.Properties.Settings.Default.INDEX;
            this.indexBox.TextChanged += new System.EventHandler(this.indexBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "INDEX File :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.filenameBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name :";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(118, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // filenameBox
            // 
            this.filenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameBox.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameBox.Location = new System.Drawing.Point(48, 21);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(145, 23);
            this.filenameBox.TabIndex = 0;
            this.filenameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filenameBox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileList);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 421);
            this.panel1.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.LabelEdit = true;
            this.fileList.Location = new System.Drawing.Point(0, 35);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(200, 279);
            this.fileList.SmallImageList = this.imageList1;
            this.fileList.TabIndex = 3;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.fileList_AfterLabelEdit);
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            this.fileList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fileList_KeyUp);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "File Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Path";
            this.columnHeader5.Width = 180;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bfolder.png");
            this.imageList1.Images.SetKeyName(1, "blist.png");
            this.imageList1.Images.SetKeyName(2, "pfile.png");
            this.imageList1.Images.SetKeyName(3, "pfolder.png");
            this.imageList1.Images.SetKeyName(4, "pstar.png");
            this.imageList1.Images.SetKeyName(5, "root.png");
            this.imageList1.Images.SetKeyName(6, "big.png");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MistyRose;
            this.panel5.Controls.Add(this.deleteListButton);
            this.panel5.Controls.Add(this.editListButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 314);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 30);
            this.panel5.TabIndex = 18;
            // 
            // deleteListButton
            // 
            this.deleteListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteListButton.Enabled = false;
            this.deleteListButton.Location = new System.Drawing.Point(122, 3);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(75, 24);
            this.deleteListButton.TabIndex = 15;
            this.deleteListButton.Text = "Delete";
            this.deleteListButton.UseVisualStyleBackColor = true;
            this.deleteListButton.Click += new System.EventHandler(this.deleteListButton_Click);
            // 
            // editListButton
            // 
            this.editListButton.Enabled = false;
            this.editListButton.Location = new System.Drawing.Point(3, 3);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(75, 24);
            this.editListButton.TabIndex = 14;
            this.editListButton.Text = "Edit";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.editListButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 35);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(200, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.backTableLayout);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(709, 421);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.ItemHeight = 20;
            this.treeView.Location = new System.Drawing.Point(0, 35);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(289, 356);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyUp);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MistyRose;
            this.panel7.Controls.Add(this.editTreeButton);
            this.panel7.Controls.Add(this.deleteTreeButton);
            this.panel7.Controls.Add(this.reloadTreeButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 391);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 30);
            this.panel7.TabIndex = 19;
            // 
            // editTreeButton
            // 
            this.editTreeButton.Enabled = false;
            this.editTreeButton.Location = new System.Drawing.Point(130, 3);
            this.editTreeButton.Name = "editTreeButton";
            this.editTreeButton.Size = new System.Drawing.Size(75, 24);
            this.editTreeButton.TabIndex = 16;
            this.editTreeButton.Text = "Edit";
            this.editTreeButton.UseVisualStyleBackColor = true;
            this.editTreeButton.Click += new System.EventHandler(this.editTreeButton_Click);
            // 
            // deleteTreeButton
            // 
            this.deleteTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTreeButton.Enabled = false;
            this.deleteTreeButton.Location = new System.Drawing.Point(211, 3);
            this.deleteTreeButton.Name = "deleteTreeButton";
            this.deleteTreeButton.Size = new System.Drawing.Size(75, 24);
            this.deleteTreeButton.TabIndex = 15;
            this.deleteTreeButton.Text = "Delete";
            this.deleteTreeButton.UseVisualStyleBackColor = true;
            this.deleteTreeButton.Click += new System.EventHandler(this.deleteTreeButton_Click);
            // 
            // reloadTreeButton
            // 
            this.reloadTreeButton.Location = new System.Drawing.Point(3, 3);
            this.reloadTreeButton.Name = "reloadTreeButton";
            this.reloadTreeButton.Size = new System.Drawing.Size(75, 24);
            this.reloadTreeButton.TabIndex = 14;
            this.reloadTreeButton.Text = "Reload";
            this.reloadTreeButton.UseVisualStyleBackColor = true;
            this.reloadTreeButton.Click += new System.EventHandler(this.reloadTreeButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.Controls.Add(this.catFileLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 35);
            this.panel6.TabIndex = 3;
            // 
            // catFileLabel
            // 
            this.catFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catFileLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFileLabel.Location = new System.Drawing.Point(0, 0);
            this.catFileLabel.Name = "catFileLabel";
            this.catFileLabel.Size = new System.Drawing.Size(289, 35);
            this.catFileLabel.TabIndex = 0;
            this.catFileLabel.Text = "No Opened Category";
            this.catFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.catnameBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.catnoteBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.problemList, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.branchList, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 352);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteBranchButton);
            this.panel4.Controls.Add(this.addBranchButton);
            this.panel4.Controls.Add(this.editBranchButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(70, 322);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 30);
            this.panel4.TabIndex = 17;
            // 
            // deleteBranchButton
            // 
            this.deleteBranchButton.Enabled = false;
            this.deleteBranchButton.Location = new System.Drawing.Point(84, 3);
            this.deleteBranchButton.Name = "deleteBranchButton";
            this.deleteBranchButton.Size = new System.Drawing.Size(75, 24);
            this.deleteBranchButton.TabIndex = 15;
            this.deleteBranchButton.Text = "Delete";
            this.deleteBranchButton.UseVisualStyleBackColor = true;
            this.deleteBranchButton.Click += new System.EventHandler(this.deleteBranchButton_Click);
            // 
            // addBranchButton
            // 
            this.addBranchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBranchButton.Location = new System.Drawing.Point(237, 3);
            this.addBranchButton.Name = "addBranchButton";
            this.addBranchButton.Size = new System.Drawing.Size(105, 24);
            this.addBranchButton.TabIndex = 8;
            this.addBranchButton.Text = "Add Branch";
            this.addBranchButton.UseVisualStyleBackColor = true;
            this.addBranchButton.Click += new System.EventHandler(this.addBranchButton_Click);
            // 
            // editBranchButton
            // 
            this.editBranchButton.Enabled = false;
            this.editBranchButton.Location = new System.Drawing.Point(3, 3);
            this.editBranchButton.Name = "editBranchButton";
            this.editBranchButton.Size = new System.Drawing.Size(75, 24);
            this.editBranchButton.TabIndex = 14;
            this.editBranchButton.Text = "Edit";
            this.editBranchButton.UseVisualStyleBackColor = true;
            this.editBranchButton.Click += new System.EventHandler(this.editBranchButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteProbButton);
            this.panel3.Controls.Add(this.editProbButton);
            this.panel3.Controls.Add(this.addProbButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(70, 186);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 30);
            this.panel3.TabIndex = 16;
            // 
            // deleteProbButton
            // 
            this.deleteProbButton.Enabled = false;
            this.deleteProbButton.Location = new System.Drawing.Point(84, 3);
            this.deleteProbButton.Name = "deleteProbButton";
            this.deleteProbButton.Size = new System.Drawing.Size(75, 24);
            this.deleteProbButton.TabIndex = 13;
            this.deleteProbButton.Text = "Delete";
            this.deleteProbButton.UseVisualStyleBackColor = true;
            this.deleteProbButton.Click += new System.EventHandler(this.deleteProbButton_Click);
            // 
            // editProbButton
            // 
            this.editProbButton.Enabled = false;
            this.editProbButton.Location = new System.Drawing.Point(3, 3);
            this.editProbButton.Name = "editProbButton";
            this.editProbButton.Size = new System.Drawing.Size(75, 24);
            this.editProbButton.TabIndex = 12;
            this.editProbButton.Text = "Edit";
            this.editProbButton.UseVisualStyleBackColor = true;
            this.editProbButton.Click += new System.EventHandler(this.editProbButton_Click);
            // 
            // addProbButton
            // 
            this.addProbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProbButton.Location = new System.Drawing.Point(237, 3);
            this.addProbButton.Name = "addProbButton";
            this.addProbButton.Size = new System.Drawing.Size(105, 24);
            this.addProbButton.TabIndex = 8;
            this.addProbButton.Text = "Add Problem";
            this.addProbButton.UseVisualStyleBackColor = true;
            this.addProbButton.Click += new System.EventHandler(this.addProbButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Branches :";
            // 
            // catnameBox
            // 
            this.catnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.catnameBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnameBox.Location = new System.Drawing.Point(73, 3);
            this.catnameBox.Name = "catnameBox";
            this.catnameBox.Size = new System.Drawing.Size(340, 24);
            this.catnameBox.TabIndex = 9;
            this.catnameBox.TextChanged += new System.EventHandler(this.catnameBox_TextChanged);
            // 
            // catnoteBox
            // 
            this.catnoteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catnoteBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnoteBox.Location = new System.Drawing.Point(73, 33);
            this.catnoteBox.Multiline = true;
            this.catnoteBox.Name = "catnoteBox";
            this.catnoteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.catnoteBox.Size = new System.Drawing.Size(340, 44);
            this.catnoteBox.TabIndex = 11;
            this.catnoteBox.TextChanged += new System.EventHandler(this.catnoteBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Notes :";
            // 
            // problemList
            // 
            this.problemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberCol,
            this.StarCol,
            this.NotesCol});
            this.problemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.problemList.FullRowSelect = true;
            this.problemList.GridLines = true;
            this.problemList.HideSelection = false;
            this.problemList.LabelEdit = true;
            this.problemList.Location = new System.Drawing.Point(73, 83);
            this.problemList.Name = "problemList";
            this.problemList.Size = new System.Drawing.Size(340, 100);
            this.problemList.TabIndex = 4;
            this.problemList.UseCompatibleStateImageBehavior = false;
            this.problemList.View = System.Windows.Forms.View.Details;
            this.problemList.SelectedIndexChanged += new System.EventHandler(this.problemList_SelectedIndexChanged);
            this.problemList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.problemList_KeyUp);
            // 
            // NumberCol
            // 
            this.NumberCol.Text = "Number";
            this.NumberCol.Width = 80;
            // 
            // StarCol
            // 
            this.StarCol.Text = "Star";
            this.StarCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NotesCol
            // 
            this.NotesCol.Text = "Note";
            this.NotesCol.Width = 180;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Problems :";
            // 
            // branchList
            // 
            this.branchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.branchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchList.FullRowSelect = true;
            this.branchList.GridLines = true;
            this.branchList.HideSelection = false;
            this.branchList.LabelEdit = true;
            this.branchList.Location = new System.Drawing.Point(73, 219);
            this.branchList.Name = "branchList";
            this.branchList.Size = new System.Drawing.Size(340, 100);
            this.branchList.TabIndex = 13;
            this.branchList.UseCompatibleStateImageBehavior = false;
            this.branchList.View = System.Windows.Forms.View.Details;
            this.branchList.SelectedIndexChanged += new System.EventHandler(this.branchList_SelectedIndexChanged);
            this.branchList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.branchList_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Note";
            this.columnHeader2.Width = 180;
            // 
            // backTableLayout
            // 
            this.backTableLayout.BackColor = System.Drawing.Color.FloralWhite;
            this.backTableLayout.ColumnCount = 2;
            this.backTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.backTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backTableLayout.Controls.Add(this.backButton, 0, 0);
            this.backTableLayout.Controls.Add(this.pathLabel, 1, 0);
            this.backTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.backTableLayout.Location = new System.Drawing.Point(0, 0);
            this.backTableLayout.Name = "backTableLayout";
            this.backTableLayout.RowCount = 1;
            this.backTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backTableLayout.Size = new System.Drawing.Size(416, 35);
            this.backTableLayout.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Image = global::CategoryEditor.Properties.Resources.prev;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.AutoSize = true;
            this.pathLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathLabel.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(103, 10);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(310, 15);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "...";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.583F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.417F));
            this.tableLayoutPanel3.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 387);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(416, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(293, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 28);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Editor";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.backTableLayout.ResumeLayout(false);
            this.backTableLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox catnoteBox;
        private System.Windows.Forms.TextBox catnameBox;
        private System.Windows.Forms.Button addProbButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel backTableLayout;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView problemList;
        private System.Windows.Forms.ListView branchList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addBranchButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader NumberCol;
        private System.Windows.Forms.ColumnHeader StarCol;
        private System.Windows.Forms.ColumnHeader NotesCol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button editProbButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteBranchButton;
        private System.Windows.Forms.Button editBranchButton;
        private System.Windows.Forms.Button deleteProbButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteListButton;
        private System.Windows.Forms.Button editListButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label catFileLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button editTreeButton;
        private System.Windows.Forms.Button deleteTreeButton;
        private System.Windows.Forms.Button reloadTreeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox filenameBox;
    }
}

