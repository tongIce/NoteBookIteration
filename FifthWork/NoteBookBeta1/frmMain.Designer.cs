namespace NoteBookUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_small = new System.Windows.Forms.PictureBox();
            this.tb_notebookName = new System.Windows.Forms.TextBox();
            this.pb_fontSize = new System.Windows.Forms.PictureBox();
            this.pb_fontColor = new System.Windows.Forms.PictureBox();
            this.pb_save = new System.Windows.Forms.PictureBox();
            this.pb_saveAs = new System.Windows.Forms.PictureBox();
            this.pb_openFile = new System.Windows.Forms.PictureBox();
            this.rtb_notebook = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_insertPicture = new System.Windows.Forms.PictureBox();
            this.pb_deleteNotebook = new System.Windows.Forms.PictureBox();
            this.pb_NewFileName = new System.Windows.Forms.PictureBox();
            this.label_saveTime = new System.Windows.Forms.Label();
            this.pb_headPicture = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pb_searchNotebook = new System.Windows.Forms.PictureBox();
            this.pb_clothesChange = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_file = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_file = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_searchNotebook = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userFileNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_filesName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_saveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_openFile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteNotebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NewFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchNotebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clothesChange)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_file.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFileNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_back
            // 
            this.pb_back.BackgroundImage = global::NoteBookUI.Properties.Resources.back_white;
            this.pb_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_back.Location = new System.Drawing.Point(1328, 25);
            this.pb_back.Margin = new System.Windows.Forms.Padding(4);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(33, 31);
            this.pb_back.TabIndex = 3;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_small
            // 
            this.pb_small.BackgroundImage = global::NoteBookUI.Properties.Resources.small_white;
            this.pb_small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_small.Location = new System.Drawing.Point(1275, 25);
            this.pb_small.Margin = new System.Windows.Forms.Padding(4);
            this.pb_small.Name = "pb_small";
            this.pb_small.Size = new System.Drawing.Size(33, 31);
            this.pb_small.TabIndex = 4;
            this.pb_small.TabStop = false;
            this.pb_small.Click += new System.EventHandler(this.pb_small_Click);
            // 
            // tb_notebookName
            // 
            this.tb_notebookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_notebookName.Font = new System.Drawing.Font("楷体", 21F);
            this.tb_notebookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_notebookName.Location = new System.Drawing.Point(9, 12);
            this.tb_notebookName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_notebookName.Multiline = true;
            this.tb_notebookName.Name = "tb_notebookName";
            this.tb_notebookName.ReadOnly = true;
            this.tb_notebookName.Size = new System.Drawing.Size(417, 44);
            this.tb_notebookName.TabIndex = 5;
            this.tb_notebookName.Text = "无标题笔记";
            // 
            // pb_fontSize
            // 
            this.pb_fontSize.BackColor = System.Drawing.Color.Transparent;
            this.pb_fontSize.BackgroundImage = global::NoteBookUI.Properties.Resources.font_size;
            this.pb_fontSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_fontSize.Location = new System.Drawing.Point(778, 18);
            this.pb_fontSize.Margin = new System.Windows.Forms.Padding(4);
            this.pb_fontSize.Name = "pb_fontSize";
            this.pb_fontSize.Size = new System.Drawing.Size(35, 32);
            this.pb_fontSize.TabIndex = 15;
            this.pb_fontSize.TabStop = false;
            this.pb_fontSize.Click += new System.EventHandler(this.pb_fontSize_Click);
            // 
            // pb_fontColor
            // 
            this.pb_fontColor.BackColor = System.Drawing.Color.Transparent;
            this.pb_fontColor.BackgroundImage = global::NoteBookUI.Properties.Resources.font_color;
            this.pb_fontColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_fontColor.Location = new System.Drawing.Point(831, 18);
            this.pb_fontColor.Margin = new System.Windows.Forms.Padding(4);
            this.pb_fontColor.Name = "pb_fontColor";
            this.pb_fontColor.Size = new System.Drawing.Size(35, 32);
            this.pb_fontColor.TabIndex = 16;
            this.pb_fontColor.TabStop = false;
            this.pb_fontColor.Click += new System.EventHandler(this.pb_fontColor_Click);
            // 
            // pb_save
            // 
            this.pb_save.BackColor = System.Drawing.Color.Transparent;
            this.pb_save.BackgroundImage = global::NoteBookUI.Properties.Resources.save;
            this.pb_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_save.Location = new System.Drawing.Point(1048, 18);
            this.pb_save.Margin = new System.Windows.Forms.Padding(4);
            this.pb_save.Name = "pb_save";
            this.pb_save.Size = new System.Drawing.Size(35, 32);
            this.pb_save.TabIndex = 17;
            this.pb_save.TabStop = false;
            this.pb_save.Click += new System.EventHandler(this.pb_save_Click);
            // 
            // pb_saveAs
            // 
            this.pb_saveAs.BackColor = System.Drawing.Color.Transparent;
            this.pb_saveAs.BackgroundImage = global::NoteBookUI.Properties.Resources.save_as;
            this.pb_saveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_saveAs.Location = new System.Drawing.Point(940, 18);
            this.pb_saveAs.Margin = new System.Windows.Forms.Padding(4);
            this.pb_saveAs.Name = "pb_saveAs";
            this.pb_saveAs.Size = new System.Drawing.Size(35, 32);
            this.pb_saveAs.TabIndex = 18;
            this.pb_saveAs.TabStop = false;
            this.pb_saveAs.Click += new System.EventHandler(this.pb_saveAs_Click);
            // 
            // pb_openFile
            // 
            this.pb_openFile.BackColor = System.Drawing.Color.Transparent;
            this.pb_openFile.BackgroundImage = global::NoteBookUI.Properties.Resources.openFile;
            this.pb_openFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_openFile.Location = new System.Drawing.Point(885, 18);
            this.pb_openFile.Margin = new System.Windows.Forms.Padding(4);
            this.pb_openFile.Name = "pb_openFile";
            this.pb_openFile.Size = new System.Drawing.Size(35, 32);
            this.pb_openFile.TabIndex = 19;
            this.pb_openFile.TabStop = false;
            this.pb_openFile.Click += new System.EventHandler(this.pb_openFile_Click);
            // 
            // rtb_notebook
            // 
            this.rtb_notebook.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_notebook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_notebook.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_notebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rtb_notebook.Location = new System.Drawing.Point(245, 314);
            this.rtb_notebook.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_notebook.Name = "rtb_notebook";
            this.rtb_notebook.ReadOnly = true;
            this.rtb_notebook.Size = new System.Drawing.Size(1131, 533);
            this.rtb_notebook.TabIndex = 20;
            this.rtb_notebook.Text = "";
            this.rtb_notebook.TextChanged += new System.EventHandler(this.rtb_notebook_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pb_insertPicture);
            this.panel1.Controls.Add(this.pb_deleteNotebook);
            this.panel1.Controls.Add(this.cb_filesName);
            this.panel1.Controls.Add(this.pb_NewFileName);
            this.panel1.Controls.Add(this.label_saveTime);
            this.panel1.Controls.Add(this.tb_notebookName);
            this.panel1.Controls.Add(this.pb_save);
            this.panel1.Controls.Add(this.pb_saveAs);
            this.panel1.Controls.Add(this.pb_openFile);
            this.panel1.Controls.Add(this.pb_fontColor);
            this.panel1.Controls.Add(this.pb_fontSize);
            this.panel1.Location = new System.Drawing.Point(245, 250);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 65);
            this.panel1.TabIndex = 21;
            // 
            // pb_insertPicture
            // 
            this.pb_insertPicture.BackColor = System.Drawing.Color.Transparent;
            this.pb_insertPicture.BackgroundImage = global::NoteBookUI.Properties.Resources.插入图片__1_;
            this.pb_insertPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_insertPicture.Location = new System.Drawing.Point(725, 18);
            this.pb_insertPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pb_insertPicture.Name = "pb_insertPicture";
            this.pb_insertPicture.Size = new System.Drawing.Size(32, 32);
            this.pb_insertPicture.TabIndex = 35;
            this.pb_insertPicture.TabStop = false;
            this.pb_insertPicture.Click += new System.EventHandler(this.pb_insertPicture_Click);
            // 
            // pb_deleteNotebook
            // 
            this.pb_deleteNotebook.BackColor = System.Drawing.Color.Transparent;
            this.pb_deleteNotebook.BackgroundImage = global::NoteBookUI.Properties.Resources.delete_000;
            this.pb_deleteNotebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_deleteNotebook.Location = new System.Drawing.Point(995, 18);
            this.pb_deleteNotebook.Margin = new System.Windows.Forms.Padding(4);
            this.pb_deleteNotebook.Name = "pb_deleteNotebook";
            this.pb_deleteNotebook.Size = new System.Drawing.Size(35, 32);
            this.pb_deleteNotebook.TabIndex = 34;
            this.pb_deleteNotebook.TabStop = false;
            this.pb_deleteNotebook.Click += new System.EventHandler(this.pb_deleteNotebook_Click);
            // 
            // pb_NewFileName
            // 
            this.pb_NewFileName.BackColor = System.Drawing.Color.Transparent;
            this.pb_NewFileName.BackgroundImage = global::NoteBookUI.Properties.Resources.add_4A1;
            this.pb_NewFileName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_NewFileName.Location = new System.Drawing.Point(672, 18);
            this.pb_NewFileName.Margin = new System.Windows.Forms.Padding(4);
            this.pb_NewFileName.Name = "pb_NewFileName";
            this.pb_NewFileName.Size = new System.Drawing.Size(35, 32);
            this.pb_NewFileName.TabIndex = 32;
            this.pb_NewFileName.TabStop = false;
            this.pb_NewFileName.Click += new System.EventHandler(this.pb_NewFileName_Click);
            // 
            // label_saveTime
            // 
            this.label_saveTime.AutoSize = true;
            this.label_saveTime.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_saveTime.Location = new System.Drawing.Point(434, 30);
            this.label_saveTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saveTime.Name = "label_saveTime";
            this.label_saveTime.Size = new System.Drawing.Size(49, 20);
            this.label_saveTime.TabIndex = 20;
            this.label_saveTime.Text = "Time";
            // 
            // pb_headPicture
            // 
            this.pb_headPicture.BackgroundImage = global::NoteBookUI.Properties.Resources.头像__1_;
            this.pb_headPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_headPicture.ErrorImage = global::NoteBookUI.Properties.Resources.头像__1_;
            this.pb_headPicture.Location = new System.Drawing.Point(40, 12);
            this.pb_headPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pb_headPicture.Name = "pb_headPicture";
            this.pb_headPicture.Size = new System.Drawing.Size(53, 50);
            this.pb_headPicture.TabIndex = 23;
            this.pb_headPicture.TabStop = false;
            this.pb_headPicture.Click += new System.EventHandler(this.pb_headPicture_Click);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.Window;
            this.label_UserName.Location = new System.Drawing.Point(101, 25);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(96, 25);
            this.label_UserName.TabIndex = 24;
            this.label_UserName.Text = "label1";
            this.label_UserName.Click += new System.EventHandler(this.label_UserName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Gif|*.gif|bmp文件(*.bmp)|*.bmp|jpg文件（*.jpg）|*.jpg|ico文件(*.ico)|*.ico|png文件|*.png";
            this.openFileDialog1.Title = "选择";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_1.ico");
            this.imageList1.Images.SetKeyName(1, "folder(1).ico");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::NoteBookUI.Properties.Resources.search_background;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(392, 12);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(345, 50);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pb_searchNotebook
            // 
            this.pb_searchNotebook.BackColor = System.Drawing.SystemColors.Window;
            this.pb_searchNotebook.BackgroundImage = global::NoteBookUI.Properties.Resources.search;
            this.pb_searchNotebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_searchNotebook.Location = new System.Drawing.Point(691, 26);
            this.pb_searchNotebook.Margin = new System.Windows.Forms.Padding(4);
            this.pb_searchNotebook.Name = "pb_searchNotebook";
            this.pb_searchNotebook.Size = new System.Drawing.Size(23, 24);
            this.pb_searchNotebook.TabIndex = 26;
            this.pb_searchNotebook.TabStop = false;
            this.pb_searchNotebook.Click += new System.EventHandler(this.pb_searchNotebook_Click);
            // 
            // pb_clothesChange
            // 
            this.pb_clothesChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_clothesChange.Location = new System.Drawing.Point(1219, 25);
            this.pb_clothesChange.Margin = new System.Windows.Forms.Padding(4);
            this.pb_clothesChange.Name = "pb_clothesChange";
            this.pb_clothesChange.Size = new System.Drawing.Size(33, 31);
            this.pb_clothesChange.TabIndex = 27;
            this.pb_clothesChange.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.panel_file);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 771);
            this.panel2.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Notes,
            this.Time,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(0, 467);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(246, 771);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "内容";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes.Width = 80;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 80;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 50);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(246, 413);
            this.treeView1.TabIndex = 33;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.Location = new System.Drawing.Point(0, 467);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 402);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel_file
            // 
            this.panel_file.Controls.Add(this.pictureBox4);
            this.panel_file.Controls.Add(this.label_file);
            this.panel_file.Controls.Add(this.pictureBox9);
            this.panel_file.Location = new System.Drawing.Point(0, 2);
            this.panel_file.Margin = new System.Windows.Forms.Padding(4);
            this.panel_file.Name = "panel_file";
            this.panel_file.Size = new System.Drawing.Size(246, 50);
            this.panel_file.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(16, 11);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_file.ForeColor = System.Drawing.SystemColors.Window;
            this.label_file.Location = new System.Drawing.Point(77, 16);
            this.label_file.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(65, 18);
            this.label_file.TabIndex = 25;
            this.label_file.Text = "文件夹";
            this.label_file.Click += new System.EventHandler(this.label_file_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::NoteBookUI.Properties.Resources.file_FFF;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Location = new System.Drawing.Point(40, 9);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(33, 31);
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件夹ToolStripMenuItem,
            this.删除文件夹ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.新建笔记ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 100);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 删除文件夹ToolStripMenuItem
            // 
            this.删除文件夹ToolStripMenuItem.Name = "删除文件夹ToolStripMenuItem";
            this.删除文件夹ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.删除文件夹ToolStripMenuItem.Text = "删除文件夹";
            this.删除文件夹ToolStripMenuItem.Click += new System.EventHandler(this.删除文件夹ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 新建笔记ToolStripMenuItem
            // 
            this.新建笔记ToolStripMenuItem.Name = "新建笔记ToolStripMenuItem";
            this.新建笔记ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.新建笔记ToolStripMenuItem.Text = "新建笔记";
            this.新建笔记ToolStripMenuItem.Click += new System.EventHandler(this.新建笔记ToolStripMenuItem_Click);
            // 
            // tb_searchNotebook
            // 
            this.tb_searchNotebook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_searchNotebook.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_searchNotebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_searchNotebook.Location = new System.Drawing.Point(415, 25);
            this.tb_searchNotebook.Margin = new System.Windows.Forms.Padding(4);
            this.tb_searchNotebook.Name = "tb_searchNotebook";
            this.tb_searchNotebook.Size = new System.Drawing.Size(268, 29);
            this.tb_searchNotebook.TabIndex = 29;
            this.tb_searchNotebook.Text = "搜索笔记";
            this.tb_searchNotebook.TextChanged += new System.EventHandler(this.tb_searchNotebook_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::NoteBookUI.Properties.Resources.background1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(245, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 175);
            this.panel3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(420, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "随时随地，记录我的笔记";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(508, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoteBook";
            // 
            // userFileNameBindingSource
            // 
            this.userFileNameBindingSource.DataMember = "UserFileName";
            // 
            // cb_filesName
            // 
            this.cb_filesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filesName.FormattingEnabled = true;
            this.cb_filesName.Location = new System.Drawing.Point(491, 25);
            this.cb_filesName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_filesName.Name = "cb_filesName";
            this.cb_filesName.Size = new System.Drawing.Size(160, 23);
            this.cb_filesName.Sorted = true;
            this.cb_filesName.TabIndex = 33;
            this.cb_filesName.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1377, 846);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_searchNotebook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtb_notebook);
            this.Controls.Add(this.pb_clothesChange);
            this.Controls.Add(this.pb_searchNotebook);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.pb_headPicture);
            this.Controls.Add(this.pb_small);
            this.Controls.Add(this.pb_back);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1377, 846);
            this.MinimumSize = new System.Drawing.Size(1377, 846);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_saveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_openFile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteNotebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NewFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchNotebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clothesChange)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_file.ResumeLayout(false);
            this.panel_file.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFileNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.PictureBox pb_small;
        private System.Windows.Forms.TextBox tb_notebookName;
        private System.Windows.Forms.PictureBox pb_fontSize;
        private System.Windows.Forms.PictureBox pb_fontColor;
        private System.Windows.Forms.PictureBox pb_save;
        private System.Windows.Forms.PictureBox pb_saveAs;
        private System.Windows.Forms.PictureBox pb_openFile;
        private System.Windows.Forms.RichTextBox rtb_notebook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_headPicture;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pb_searchNotebook;
        private System.Windows.Forms.PictureBox pb_clothesChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_file;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox tb_searchNotebook;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_saveTime;

        //private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.PictureBox pb_NewFileName;
        private System.Windows.Forms.PictureBox pb_deleteNotebook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        //private CSharpDataSetTableAdapters.UserFileNameTableAdapter userFileNameTableAdapter;
        private System.Windows.Forms.BindingSource userFileNameBindingSource;
        private System.Windows.Forms.PictureBox pb_insertPicture;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem 新建笔记ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_filesName;
        //private CSharpDataSet cSharpDataSet;
    }
}