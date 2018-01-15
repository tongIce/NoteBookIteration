using System.Windows.Forms;
using System.Drawing;
namespace NoteBookUI
{
    public partial class LoginForm : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_yanzhengma = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_yzm = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            this.toolTip1.IsBalloon = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(493, 320);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.MaxLength = 16;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 25);
            this.txt_name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_name, "用户名");
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.White;
            this.txt_pwd.Location = new System.Drawing.Point(493, 364);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pwd.MaxLength = 16;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(169, 25);
            this.txt_pwd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_pwd, "密码");
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // txt_yanzhengma
            // 
            this.txt_yanzhengma.Location = new System.Drawing.Point(491, 413);
            this.txt_yanzhengma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yanzhengma.MaxLength = 4;
            this.txt_yanzhengma.Name = "txt_yanzhengma";
            this.txt_yanzhengma.Size = new System.Drawing.Size(95, 25);
            this.txt_yanzhengma.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_yanzhengma, "验证码");
            this.txt_yanzhengma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yanzhengma_KeyPress);
            this.txt_yanzhengma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_yanzhengma_KeyUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "笔记本_V1.0";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Text = "笔记本_V1.0";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于系统ToolStripMenuItem,
            this.退出系统ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.ShowImageMargin = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 52);
            this.contextMenuStrip2.Text = "帮助";
            // 
            // 关于系统ToolStripMenuItem
            // 
            this.关于系统ToolStripMenuItem.Name = "关于系统ToolStripMenuItem";
            this.关于系统ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.关于系统ToolStripMenuItem.Text = "关于系统";
            this.关于系统ToolStripMenuItem.Click += new System.EventHandler(this.关于系统ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem1
            // 
            this.退出系统ToolStripMenuItem1.Name = "退出系统ToolStripMenuItem1";
            this.退出系统ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.退出系统ToolStripMenuItem1.Text = "退出系统";
            this.退出系统ToolStripMenuItem1.Click += new System.EventHandler(this.退出系统ToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.Location = new System.Drawing.Point(580, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "登 陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(410, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(132)))), ((int)(((byte)(250)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("宋体", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(420, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = " 注 册 ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(409, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "验证：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_yzm);
            this.groupBox2.Location = new System.Drawing.Point(593, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(69, 28);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl_yzm
            // 
            this.lbl_yzm.AutoSize = true;
            this.lbl_yzm.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_yzm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_yzm.Location = new System.Drawing.Point(12, 4);
            this.lbl_yzm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yzm.Name = "lbl_yzm";
            this.lbl_yzm.Size = new System.Drawing.Size(21, 20);
            this.lbl_yzm.TabIndex = 0;
            this.lbl_yzm.TabStop = true;
            this.lbl_yzm.Text = "...";
            this.lbl_yzm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_yzm_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文行楷", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(436, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 63);
            this.label5.TabIndex = 14;
            this.label5.Text = "NoteBook";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 701);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_yanzhengma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1002, 707);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1002, 707);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.From_ManageLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.From_ManageLogin_Paint);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// 设置登录按钮圆角
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Paint(object sender, PaintEventArgs e)
        {
            UiUtil.Draw(e.ClipRectangle, e.Graphics, 40, false, Color.FromArgb(0, 163, 255), Color.FromArgb(0, 163, 255));
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString("退出登录", new Font("新宋体", 9F, FontStyle.Regular), new SolidBrush(Color.White), new PointF(72, 8));
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lbl_yzm;
        private System.Windows.Forms.TextBox txt_yanzhengma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 关于系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem1;
    }
}