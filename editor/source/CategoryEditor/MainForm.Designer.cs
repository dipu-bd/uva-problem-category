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
            this.fileList = new BrightIdeasSoftware.FastObjectListView();
            this.fileNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileVersionCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hideCategoryList = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeList = new BrightIdeasSoftware.TreeListView();
            this.nameTreeCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editTreeButton = new System.Windows.Forms.Button();
            this.deleteTreeButton = new System.Windows.Forms.Button();
            this.reloadTreeButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.catFileLabel = new System.Windows.Forms.Label();
            this.hideTreeList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wizardTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBatchButton = new System.Windows.Forms.Button();
            this.deleteProbButton = new System.Windows.Forms.Button();
            this.editProbButton = new System.Windows.Forms.Button();
            this.addProbButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.catnameBox = new System.Windows.Forms.TextBox();
            this.catnoteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.problemListView = new BrightIdeasSoftware.FastObjectListView();
            this.pnumProb = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.starProb = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.noteProb = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.editorTab = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.backTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.wizardTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problemListView)).BeginInit();
            this.editorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
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
            this.addButton.Location = new System.Drawing.Point(118, 48);
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
            this.fileList.AllColumns.Add(this.fileNameCol);
            this.fileList.AllColumns.Add(this.fileVersionCol);
            this.fileList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.fileList.CellEditTabChangesRows = true;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameCol,
            this.fileVersionCol});
            this.fileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.EmptyListMsg = "Add new category";
            this.fileList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(0, 35);
            this.fileList.MultiSelect = false;
            this.fileList.Name = "fileList";
            this.fileList.ShowGroups = false;
            this.fileList.ShowItemToolTips = true;
            this.fileList.Size = new System.Drawing.Size(200, 279);
            this.fileList.TabIndex = 21;
            this.fileList.UseCellFormatEvents = true;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.UseCustomSelectionColors = true;
            this.fileList.UseHotItem = true;
            this.fileList.UseTranslucentHotItem = true;
            this.fileList.UseTranslucentSelection = true;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.VirtualMode = true;
            this.fileList.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.fileList_CellEditFinishing);
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            this.fileList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fileList_KeyUp);
            // 
            // fileNameCol
            // 
            this.fileNameCol.AspectName = "file";
            this.fileNameCol.Text = "File Name";
            this.fileNameCol.Width = 135;
            // 
            // fileVersionCol
            // 
            this.fileVersionCol.AspectName = "ver";
            this.fileVersionCol.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileVersionCol.Text = "Version";
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
            this.panel2.Controls.Add(this.hideCategoryList);
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
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideCategoryList
            // 
            this.hideCategoryList.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideCategoryList.Location = new System.Drawing.Point(175, 0);
            this.hideCategoryList.Name = "hideCategoryList";
            this.hideCategoryList.Size = new System.Drawing.Size(25, 35);
            this.hideCategoryList.TabIndex = 2;
            this.hideCategoryList.Text = "<";
            this.hideCategoryList.UseVisualStyleBackColor = true;
            this.hideCategoryList.Click += new System.EventHandler(this.hideCategoryList_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(200, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeList);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.backTableLayout);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(709, 421);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeList
            // 
            this.treeList.AllColumns.Add(this.nameTreeCol);
            this.treeList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.treeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameTreeCol});
            this.treeList.ContextMenuStrip = this.contextMenuStrip1;
            this.treeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.EmptyListMsg = "Select a category";
            this.treeList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList.HideSelection = false;
            this.treeList.Location = new System.Drawing.Point(0, 35);
            this.treeList.MultiSelect = false;
            this.treeList.Name = "treeList";
            this.treeList.OwnerDraw = true;
            this.treeList.ShowGroups = false;
            this.treeList.ShowItemToolTips = true;
            this.treeList.Size = new System.Drawing.Size(283, 356);
            this.treeList.TabIndex = 20;
            this.treeList.UseCellFormatEvents = true;
            this.treeList.UseCompatibleStateImageBehavior = false;
            this.treeList.UseCustomSelectionColors = true;
            this.treeList.UseHotItem = true;
            this.treeList.UseTranslucentHotItem = true;
            this.treeList.UseTranslucentSelection = true;
            this.treeList.View = System.Windows.Forms.View.Details;
            this.treeList.VirtualMode = true;
            this.treeList.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.treeList_CellEditFinishing);
            this.treeList.SelectionChanged += new System.EventHandler(this.treeList_SelectionChanged);
            this.treeList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyUp);
            // 
            // nameTreeCol
            // 
            this.nameTreeCol.AspectName = "name";
            this.nameTreeCol.Text = "Name";
            this.nameTreeCol.Width = 400;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.toolStripSeparator1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 126);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadTreeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.editTreeButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteTreeButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
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
            this.panel7.Size = new System.Drawing.Size(283, 30);
            this.panel7.TabIndex = 19;
            // 
            // editTreeButton
            // 
            this.editTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTreeButton.Enabled = false;
            this.editTreeButton.Location = new System.Drawing.Point(124, 3);
            this.editTreeButton.Name = "editTreeButton";
            this.editTreeButton.Size = new System.Drawing.Size(75, 24);
            this.editTreeButton.TabIndex = 16;
            this.editTreeButton.Text = "Add";
            this.editTreeButton.UseVisualStyleBackColor = true;
            this.editTreeButton.Click += new System.EventHandler(this.editTreeButton_Click);
            // 
            // deleteTreeButton
            // 
            this.deleteTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTreeButton.Enabled = false;
            this.deleteTreeButton.Location = new System.Drawing.Point(205, 3);
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
            this.panel6.Controls.Add(this.hideTreeList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 35);
            this.panel6.TabIndex = 3;
            // 
            // catFileLabel
            // 
            this.catFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catFileLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFileLabel.Location = new System.Drawing.Point(0, 0);
            this.catFileLabel.Name = "catFileLabel";
            this.catFileLabel.Size = new System.Drawing.Size(258, 35);
            this.catFileLabel.TabIndex = 0;
            this.catFileLabel.Text = "No Opened Category";
            this.catFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideTreeList
            // 
            this.hideTreeList.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideTreeList.Location = new System.Drawing.Point(258, 0);
            this.hideTreeList.Name = "hideTreeList";
            this.hideTreeList.Size = new System.Drawing.Size(25, 35);
            this.hideTreeList.TabIndex = 1;
            this.hideTreeList.Text = "<";
            this.hideTreeList.UseVisualStyleBackColor = true;
            this.hideTreeList.Click += new System.EventHandler(this.hideTreeList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wizardTab);
            this.tabControl1.Controls.Add(this.editorTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 352);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // wizardTab
            // 
            this.wizardTab.Controls.Add(this.tableLayoutPanel2);
            this.wizardTab.Location = new System.Drawing.Point(4, 28);
            this.wizardTab.Name = "wizardTab";
            this.wizardTab.Size = new System.Drawing.Size(414, 320);
            this.wizardTab.TabIndex = 0;
            this.wizardTab.Text = "Normal Editor";
            this.wizardTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.catnameBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.catnoteBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.problemListView, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 320);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addBatchButton);
            this.panel3.Controls.Add(this.deleteProbButton);
            this.panel3.Controls.Add(this.editProbButton);
            this.panel3.Controls.Add(this.addProbButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(70, 292);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 28);
            this.panel3.TabIndex = 16;
            // 
            // addBatchButton
            // 
            this.addBatchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBatchButton.Location = new System.Drawing.Point(185, 2);
            this.addBatchButton.Name = "addBatchButton";
            this.addBatchButton.Size = new System.Drawing.Size(75, 24);
            this.addBatchButton.TabIndex = 14;
            this.addBatchButton.Text = "Add Batch";
            this.addBatchButton.UseVisualStyleBackColor = true;
            this.addBatchButton.Click += new System.EventHandler(this.addBatch_Click);
            // 
            // deleteProbButton
            // 
            this.deleteProbButton.Enabled = false;
            this.deleteProbButton.Location = new System.Drawing.Point(84, 2);
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
            this.editProbButton.Location = new System.Drawing.Point(3, 2);
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
            this.addProbButton.Location = new System.Drawing.Point(266, 2);
            this.addProbButton.Name = "addProbButton";
            this.addProbButton.Size = new System.Drawing.Size(75, 24);
            this.addProbButton.TabIndex = 8;
            this.addProbButton.Text = "Add";
            this.addProbButton.UseVisualStyleBackColor = true;
            this.addProbButton.Click += new System.EventHandler(this.addProbButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name :";
            // 
            // catnameBox
            // 
            this.catnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.catnameBox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnameBox.Location = new System.Drawing.Point(73, 3);
            this.catnameBox.Name = "catnameBox";
            this.catnameBox.Size = new System.Drawing.Size(338, 24);
            this.catnameBox.TabIndex = 9;
            this.catnameBox.TextChanged += new System.EventHandler(this.catnameBox_TextChanged);
            // 
            // catnoteBox
            // 
            this.catnoteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catnoteBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnoteBox.Location = new System.Drawing.Point(73, 31);
            this.catnoteBox.Multiline = true;
            this.catnoteBox.Name = "catnoteBox";
            this.catnoteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.catnoteBox.Size = new System.Drawing.Size(338, 44);
            this.catnoteBox.TabIndex = 11;
            this.catnoteBox.TextChanged += new System.EventHandler(this.catnoteBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Notes :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Problems :";
            // 
            // problemListView
            // 
            this.problemListView.AllColumns.Add(this.pnumProb);
            this.problemListView.AllColumns.Add(this.starProb);
            this.problemListView.AllColumns.Add(this.noteProb);
            this.problemListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.problemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pnumProb,
            this.starProb,
            this.noteProb});
            this.problemListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.problemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.problemListView.EmptyListMsg = "Click on Add Problem";
            this.problemListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemListView.FullRowSelect = true;
            this.problemListView.HideSelection = false;
            this.problemListView.Location = new System.Drawing.Point(73, 81);
            this.problemListView.MultiSelect = false;
            this.problemListView.Name = "problemListView";
            this.problemListView.ShowGroups = false;
            this.problemListView.ShowItemToolTips = true;
            this.problemListView.Size = new System.Drawing.Size(338, 208);
            this.problemListView.TabIndex = 18;
            this.problemListView.UseCellFormatEvents = true;
            this.problemListView.UseCompatibleStateImageBehavior = false;
            this.problemListView.UseCustomSelectionColors = true;
            this.problemListView.UseHotItem = true;
            this.problemListView.UseTranslucentHotItem = true;
            this.problemListView.UseTranslucentSelection = true;
            this.problemListView.View = System.Windows.Forms.View.Details;
            this.problemListView.VirtualMode = true;
            this.problemListView.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.problemListView_CellEditFinishing);
            this.problemListView.SelectedIndexChanged += new System.EventHandler(this.problemList_SelectedIndexChanged);
            this.problemListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.problemList_KeyUp);
            // 
            // pnumProb
            // 
            this.pnumProb.AspectName = "pnum";
            this.pnumProb.Text = "Number";
            this.pnumProb.Width = 100;
            // 
            // starProb
            // 
            this.starProb.AspectName = "star";
            this.starProb.CheckBoxes = true;
            this.starProb.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.starProb.Text = "Star";
            this.starProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // noteProb
            // 
            this.noteProb.AspectName = "note";
            this.noteProb.FillsFreeSpace = true;
            this.noteProb.Text = "Notes";
            this.noteProb.Width = 200;
            // 
            // editorTab
            // 
            this.editorTab.Controls.Add(this.fastColoredTextBox1);
            this.editorTab.Location = new System.Drawing.Point(4, 28);
            this.editorTab.Name = "editorTab";
            this.editorTab.Padding = new System.Windows.Forms.Padding(3);
            this.editorTab.Size = new System.Drawing.Size(414, 320);
            this.editorTab.TabIndex = 1;
            this.editorTab.Text = "JSON Editor";
            this.editorTab.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBrackets = true;
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"'};
            this.fastColoredTextBox1.AutoIndentChars = false;
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 15);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 15;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ShowFoldingLines = true;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(408, 314);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.TabLength = 2;
            this.fastColoredTextBox1.Zoom = 100;
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
            this.backTableLayout.Size = new System.Drawing.Size(422, 35);
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
            this.pathLabel.Size = new System.Drawing.Size(316, 15);
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 387);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(422, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(299, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.wizardTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.problemListView)).EndInit();
            this.editorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox catnoteBox;
        private System.Windows.Forms.TextBox catnameBox;
        private System.Windows.Forms.Button addProbButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel backTableLayout;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button editProbButton;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wizardTab;
        private System.Windows.Forms.TabPage editorTab;
        private BrightIdeasSoftware.FastObjectListView fileList;
        private BrightIdeasSoftware.TreeListView treeList;
        private BrightIdeasSoftware.FastObjectListView problemListView;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private BrightIdeasSoftware.OLVColumn fileNameCol;
        private BrightIdeasSoftware.OLVColumn fileVersionCol;
        private BrightIdeasSoftware.OLVColumn nameTreeCol;
        private BrightIdeasSoftware.OLVColumn pnumProb;
        private BrightIdeasSoftware.OLVColumn starProb;
        private BrightIdeasSoftware.OLVColumn noteProb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.Button addBatchButton;
        private System.Windows.Forms.Button hideCategoryList;
        private System.Windows.Forms.Button hideTreeList;
    }
}

