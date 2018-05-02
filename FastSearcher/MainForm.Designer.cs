namespace MIF
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuResultList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearchMode = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonConventional = new System.Windows.Forms.RadioButton();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.richTextBoxProperties = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFilesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAllDrives = new System.Windows.Forms.Button();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDirectories = new System.Windows.Forms.TextBox();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAllDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelPattern = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.contextMenuResultList.SuspendLayout();
            this.groupBoxSearchMode.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuMain.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuResultList
            // 
            this.contextMenuResultList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.openToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.separatorToolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.contextMenuResultList.Name = "contextMenuResultList";
            this.contextMenuResultList.Size = new System.Drawing.Size(108, 142);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Enabled = false;
            this.showToolStripMenuItem.Image = global::MIF.Properties.Resources.FolderOpen_16x16_72;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.showToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.showToolStripMenuItem.ShowShortcutKeys = false;
            this.showToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.showToolStripMenuItem.Text = "&Show";
            this.showToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showToolStripMenuItem.ToolTipText = "Show file in folder explorer";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Image = global::MIF.Properties.Resources.application_view_gallery;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.ShowShortcutKeys = false;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.ToolTipText = "Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Image = global::MIF.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.ShowShortcutKeys = false;
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.ToolTipText = "Copy selected files in new directory";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Enabled = false;
            this.moveToolStripMenuItem.Image = global::MIF.Properties.Resources.move_16x16_9901;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.moveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.moveToolStripMenuItem.ShowShortcutKeys = false;
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.moveToolStripMenuItem.Text = "&Move";
            this.moveToolStripMenuItem.ToolTipText = "Move selected files in other directory";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Image = global::MIF.Properties.Resources.delete_12x12;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "ALT+D";
            this.deleteToolStripMenuItem.ShowShortcutKeys = false;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.ToolTipText = "Delete selected files";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // separatorToolStripMenuItem2
            // 
            this.separatorToolStripMenuItem2.Name = "separatorToolStripMenuItem2";
            this.separatorToolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::MIF.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Show info about program";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxSearchMode
            // 
            this.groupBoxSearchMode.Controls.Add(this.radioButtonRegular);
            this.groupBoxSearchMode.Controls.Add(this.radioButtonConventional);
            this.groupBoxSearchMode.Location = new System.Drawing.Point(18, 94);
            this.groupBoxSearchMode.Name = "groupBoxSearchMode";
            this.groupBoxSearchMode.Size = new System.Drawing.Size(226, 47);
            this.groupBoxSearchMode.TabIndex = 17;
            this.groupBoxSearchMode.TabStop = false;
            this.groupBoxSearchMode.Text = "Search mode";
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(106, 20);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(115, 17);
            this.radioButtonRegular.TabIndex = 8;
            this.radioButtonRegular.Text = "Regular expression";
            this.toolTip.SetToolTip(this.radioButtonRegular, "Pattern IS case sensitive ");
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            this.radioButtonRegular.CheckedChanged += new System.EventHandler(this.radioButtonRegular_CheckedChanged);
            // 
            // radioButtonConventional
            // 
            this.radioButtonConventional.AutoSize = true;
            this.radioButtonConventional.Checked = true;
            this.radioButtonConventional.Location = new System.Drawing.Point(11, 20);
            this.radioButtonConventional.Name = "radioButtonConventional";
            this.radioButtonConventional.Size = new System.Drawing.Size(87, 17);
            this.radioButtonConventional.TabIndex = 7;
            this.radioButtonConventional.TabStop = true;
            this.radioButtonConventional.Text = "Conventional";
            this.toolTip.SetToolTip(this.radioButtonConventional, "Pattern IS NOT case sensitive ");
            this.radioButtonConventional.UseVisualStyleBackColor = true;
            this.radioButtonConventional.CheckedChanged += new System.EventHandler(this.radioButtonConventional_CheckedChanged);
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Controls.Add(this.progressBar);
            this.groupBoxCondition.Location = new System.Drawing.Point(251, 94);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(249, 47);
            this.groupBoxCondition.TabIndex = 18;
            this.groupBoxCondition.TabStop = false;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(11, 13);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(85, 13);
            this.labelCondition.TabIndex = 18;
            this.labelCondition.Text = "Ready to search";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 29);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(222, 8);
            this.progressBar.TabIndex = 17;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonClear);
            this.groupBoxButtons.Controls.Add(this.buttonStop);
            this.groupBoxButtons.Controls.Add(this.buttonSearch);
            this.groupBoxButtons.Location = new System.Drawing.Point(507, 94);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(260, 47);
            this.groupBoxButtons.TabIndex = 19;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Image = global::MIF.Properties.Resources.clear_23227;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClear.Location = new System.Drawing.Point(10, 15);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonClear, "Clear search results list");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Enabled = false;
            this.buttonStop.Image = global::MIF.Properties.Resources.StatusAnnotations_Stop_16xLG_color;
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.Location = new System.Drawing.Point(92, 15);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonStop, "Stop search");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = global::MIF.Properties.Resources.search_glyph;
            this.buttonSearch.Location = new System.Drawing.Point(174, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSearch, "Start search");
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperties.Controls.Add(this.buttonShow);
            this.groupBoxProperties.Controls.Add(this.buttonDelete);
            this.groupBoxProperties.Controls.Add(this.buttonMove);
            this.groupBoxProperties.Controls.Add(this.buttonCopy);
            this.groupBoxProperties.Controls.Add(this.buttonOpen);
            this.groupBoxProperties.Controls.Add(this.richTextBoxProperties);
            this.groupBoxProperties.Location = new System.Drawing.Point(18, 408);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(749, 158);
            this.groupBoxProperties.TabIndex = 20;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties";
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShow.Image = global::MIF.Properties.Resources.FolderOpen_16x16_72;
            this.buttonShow.Location = new System.Drawing.Point(334, 121);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 24);
            this.buttonShow.TabIndex = 14;
            this.buttonShow.Text = "Show";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonShow, "Show file in folder explorer");
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::MIF.Properties.Resources.delete_12x12;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.Location = new System.Drawing.Point(662, 121);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 24);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonDelete, "Delete selected files");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMove.Enabled = false;
            this.buttonMove.Image = global::MIF.Properties.Resources.move_16x16_9901;
            this.buttonMove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMove.Location = new System.Drawing.Point(580, 121);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 24);
            this.buttonMove.TabIndex = 11;
            this.buttonMove.Text = "Move";
            this.buttonMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonMove, "Move selected files in other directory");
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = global::MIF.Properties.Resources.copy;
            this.buttonCopy.Location = new System.Drawing.Point(498, 121);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 24);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopy, "Copy selected files in new directory");
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.Image = global::MIF.Properties.Resources.application_view_gallery;
            this.buttonOpen.Location = new System.Drawing.Point(416, 121);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 24);
            this.buttonOpen.TabIndex = 13;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonOpen, "Open file");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // richTextBoxProperties
            // 
            this.richTextBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxProperties.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxProperties.DetectUrls = false;
            this.richTextBoxProperties.Location = new System.Drawing.Point(13, 23);
            this.richTextBoxProperties.Name = "richTextBoxProperties";
            this.richTextBoxProperties.ReadOnly = true;
            this.richTextBoxProperties.Size = new System.Drawing.Size(722, 84);
            this.richTextBoxProperties.TabIndex = 12;
            this.richTextBoxProperties.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFiles,
            this.toolStripStatusLabelFilesCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelFiles
            // 
            this.toolStripStatusLabelFiles.Name = "toolStripStatusLabelFiles";
            this.toolStripStatusLabelFiles.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabelFiles.Text = "Files:";
            // 
            // toolStripStatusLabelFilesCount
            // 
            this.toolStripStatusLabelFilesCount.Name = "toolStripStatusLabelFilesCount";
            this.toolStripStatusLabelFilesCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelFilesCount.Text = "0";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // buttonAllDrives
            // 
            this.buttonAllDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllDrives.Image = global::MIF.Properties.Resources.drive_add;
            this.buttonAllDrives.Location = new System.Drawing.Point(664, 44);
            this.buttonAllDrives.Name = "buttonAllDrives";
            this.buttonAllDrives.Size = new System.Drawing.Size(75, 24);
            this.buttonAllDrives.TabIndex = 6;
            this.buttonAllDrives.Text = "All drives";
            this.buttonAllDrives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAllDrives.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonAllDrives, "Use all drives for search");
            this.buttonAllDrives.UseVisualStyleBackColor = true;
            this.buttonAllDrives.Click += new System.EventHandler(this.buttonAllDrives_Click);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPattern.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBoxPattern.Location = new System.Drawing.Point(87, 45);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(552, 22);
            this.textBoxPattern.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxPattern, "Search pattern");
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Image = global::MIF.Properties.Resources.folder_add;
            this.buttonAdd.Location = new System.Drawing.Point(664, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 24);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonAdd, "Add search directory");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDirectories
            // 
            this.textBoxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDirectories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBoxDirectories.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBoxDirectories.Location = new System.Drawing.Point(87, 16);
            this.textBoxDirectories.Name = "textBoxDirectories";
            this.textBoxDirectories.Size = new System.Drawing.Size(552, 22);
            this.textBoxDirectories.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxDirectories, "List of directories, divided by semicolon");
            this.textBoxDirectories.TextChanged += new System.EventHandler(this.textBoxDirectories_TextChanged);
            this.textBoxDirectories.Leave += new System.EventHandler(this.textBoxDirectories_Leave);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirectoryToolStripMenuItem,
            this.useAllDrivesToolStripMenuItem,
            this.clearResultsToolStripMenuItem,
            this.stopSearchToolStripMenuItem,
            this.startSearchToolStripMenuItem,
            this.separatorToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(140, 142);
            // 
            // addDirectoryToolStripMenuItem
            // 
            this.addDirectoryToolStripMenuItem.Image = global::MIF.Properties.Resources.folder_add;
            this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            this.addDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addDirectoryToolStripMenuItem.ShowShortcutKeys = false;
            this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addDirectoryToolStripMenuItem.Text = "Add directory";
            this.addDirectoryToolStripMenuItem.ToolTipText = "&Add search directory";
            this.addDirectoryToolStripMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // useAllDrivesToolStripMenuItem
            // 
            this.useAllDrivesToolStripMenuItem.Image = global::MIF.Properties.Resources.drive_add;
            this.useAllDrivesToolStripMenuItem.Name = "useAllDrivesToolStripMenuItem";
            this.useAllDrivesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.useAllDrivesToolStripMenuItem.ShowShortcutKeys = false;
            this.useAllDrivesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.useAllDrivesToolStripMenuItem.Text = "Use all drives";
            this.useAllDrivesToolStripMenuItem.ToolTipText = "&Use all drives for search";
            this.useAllDrivesToolStripMenuItem.Click += new System.EventHandler(this.useAllDrivesToolStripMenuItem_Click);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Image = global::MIF.Properties.Resources.clear_23227;
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear results";
            this.clearResultsToolStripMenuItem.ToolTipText = "Clear search results list";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // stopSearchToolStripMenuItem
            // 
            this.stopSearchToolStripMenuItem.Image = global::MIF.Properties.Resources.StatusAnnotations_Stop_16xLG_color;
            this.stopSearchToolStripMenuItem.Name = "stopSearchToolStripMenuItem";
            this.stopSearchToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.stopSearchToolStripMenuItem.Text = "Stop search";
            this.stopSearchToolStripMenuItem.ToolTipText = "Stop search";
            this.stopSearchToolStripMenuItem.Click += new System.EventHandler(this.stopSearchToolStripMenuItem_Click);
            // 
            // startSearchToolStripMenuItem
            // 
            this.startSearchToolStripMenuItem.Image = global::MIF.Properties.Resources.search_glyph;
            this.startSearchToolStripMenuItem.Name = "startSearchToolStripMenuItem";
            this.startSearchToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.startSearchToolStripMenuItem.Text = "Start search";
            this.startSearchToolStripMenuItem.ToolTipText = "Start search";
            this.startSearchToolStripMenuItem.Click += new System.EventHandler(this.startSearchToolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem1
            // 
            this.separatorToolStripMenuItem1.Name = "separatorToolStripMenuItem1";
            this.separatorToolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::MIF.Properties.Resources.information;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.ToolTipText = "Show info about program";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonAllDrives);
            this.groupBoxSearch.Controls.Add(this.labelPattern);
            this.groupBoxSearch.Controls.Add(this.labelDirectory);
            this.groupBoxSearch.Controls.Add(this.textBoxPattern);
            this.groupBoxSearch.Controls.Add(this.buttonAdd);
            this.groupBoxSearch.Controls.Add(this.textBoxDirectories);
            this.groupBoxSearch.Location = new System.Drawing.Point(18, 9);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(749, 79);
            this.groupBoxSearch.TabIndex = 19;
            this.groupBoxSearch.TabStop = false;
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(9, 49);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(41, 13);
            this.labelPattern.TabIndex = 26;
            this.labelPattern.Text = "Pattern";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(9, 20);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(57, 13);
            this.labelDirectory.TabIndex = 25;
            this.labelDirectory.Text = "Directories";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.listBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(18, 148);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(749, 254);
            this.groupBoxResult.TabIndex = 24;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Search results";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxResult.ContextMenuStrip = this.contextMenuResultList;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(13, 24);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxResult.Size = new System.Drawing.Size(722, 212);
            this.listBoxResult.TabIndex = 9;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.ContextMenuStrip = this.contextMenuMain;
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.groupBoxSearchMode);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIF : The Most Intensive Finder";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextMenuResultList.ResumeLayout(false);
            this.groupBoxSearchMode.ResumeLayout(false);
            this.groupBoxSearchMode.PerformLayout();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxProperties.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuMain.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBoxSearchMode;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonConventional;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.RichTextBox richTextBoxProperties;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFilesCount;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuResultList;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useAllDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonAllDrives;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDirectories;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

