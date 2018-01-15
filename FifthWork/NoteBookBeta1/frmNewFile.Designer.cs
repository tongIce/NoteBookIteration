namespace NoteBookUI
{
    partial class frmNewFile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_small = new System.Windows.Forms.PictureBox();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_no = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pb_back);
            this.panel1.Controls.Add(this.pb_small);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 42);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "新建文件夹";
            // 
            // pb_back
            // 
            this.pb_back.BackgroundImage = global::NoteBookUI.Properties.Resources.back_white;
            this.pb_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_back.Location = new System.Drawing.Point(300, 7);
            this.pb_back.Margin = new System.Windows.Forms.Padding(4);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(33, 31);
            this.pb_back.TabIndex = 6;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_small
            // 
            this.pb_small.BackgroundImage = global::NoteBookUI.Properties.Resources.small_white;
            this.pb_small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_small.Location = new System.Drawing.Point(255, 4);
            this.pb_small.Margin = new System.Windows.Forms.Padding(4);
            this.pb_small.Name = "pb_small";
            this.pb_small.Size = new System.Drawing.Size(33, 31);
            this.pb_small.TabIndex = 5;
            this.pb_small.TabStop = false;
            this.pb_small.Click += new System.EventHandler(this.pb_small_Click);
            // 
            // tb_fileName
            // 
            this.tb_fileName.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_fileName.Location = new System.Drawing.Point(17, 180);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_fileName.Multiline = true;
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(316, 42);
            this.tb_fileName.TabIndex = 8;
            this.tb_fileName.TextChanged += new System.EventHandler(this.tb_fileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(16, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "文件夹名：";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_save.Location = new System.Drawing.Point(45, 314);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(69, 42);
            this.bt_save.TabIndex = 10;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_no
            // 
            this.bt_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(143)))), ((int)(((byte)(234)))));
            this.bt_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_no.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_no.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_no.Location = new System.Drawing.Point(217, 314);
            this.bt_no.Margin = new System.Windows.Forms.Padding(4);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(71, 42);
            this.bt_no.TabIndex = 11;
            this.bt_no.Text = "取消";
            this.bt_no.UseVisualStyleBackColor = false;
            this.bt_no.Click += new System.EventHandler(this.bt_no_Click);
            // 
            // frmNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(353, 404);
            this.Controls.Add(this.bt_no);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNewFile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_small)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.PictureBox pb_small;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_no;
    }
}