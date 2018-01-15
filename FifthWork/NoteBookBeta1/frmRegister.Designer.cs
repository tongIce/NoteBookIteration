using System.Windows.Forms;
using System.Drawing;
namespace NoteBookUI
{
    partial class frmRegister
    {
        private const int formWidth = 342;
        public int FormWidth
        {
            get { return formWidth; }
        }
        private const int formHeight = 231;
        public int FormHeight
        {
            get { return formHeight; }
        }
        private const int panel_Height = 47;
        public int Panel_Height
        {
            get { return panel_Height; }
        }
        private const int lb_Width = 64;
        public int Lb_Width
        {
            get { return lb_Width; }
        }
        private const int lb_Height = 15;
        public int Lb_Height
        {
            get { return lb_Height; }
        }
        private const float font_Size = 9;
        public float Font_Size
        {
            get { return font_Size; }
        }
        private const int tb_Width = 169;
        public int Tb_Width
        {
            get { return tb_Width; }
        }
        private const int tb_Height = 31;
        public int Tb_Height
        {
            get { return tb_Height; }
        }


        private System.Windows.Forms.FlowLayoutPanel flp_root;
        private System.Windows.Forms.Panel pl_usertype;
        private System.Windows.Forms.Panel pl_username;
        private System.Windows.Forms.Panel pl_password;
        private System.Windows.Forms.Panel pl_user_tip;
        private System.Windows.Forms.Panel pl_psw_tip;

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_user_tip;
        private System.Windows.Forms.Label lb_repassword;
        private System.Windows.Forms.TextBox tb_repwd;
        private System.Windows.Forms.Label lb_psw_tip;
        private Panel pl_Login;
        private Button bt_register;

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
            this.flp_root = new System.Windows.Forms.FlowLayoutPanel();
            this.pl_usertype = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.pl_username = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.pl_user_tip = new System.Windows.Forms.Panel();
            this.lb_user_tip = new System.Windows.Forms.Label();
            this.pl_password = new System.Windows.Forms.Panel();
            this.lb_repassword = new System.Windows.Forms.Label();
            this.tb_repwd = new System.Windows.Forms.TextBox();
            this.pl_psw_tip = new System.Windows.Forms.Panel();
            this.lb_psw_tip = new System.Windows.Forms.Label();
            this.pl_Login = new System.Windows.Forms.Panel();
            this.bt_register = new System.Windows.Forms.Button();
            this.flp_root.SuspendLayout();
            this.pl_usertype.SuspendLayout();
            this.pl_username.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pl_user_tip.SuspendLayout();
            this.pl_password.SuspendLayout();
            this.pl_psw_tip.SuspendLayout();
            this.pl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_root
            // 
            this.flp_root.Controls.Add(this.pl_usertype);
            this.flp_root.Controls.Add(this.pl_username);
            this.flp_root.Controls.Add(this.pl_user_tip);
            this.flp_root.Controls.Add(this.pl_password);
            this.flp_root.Controls.Add(this.pl_psw_tip);
            this.flp_root.Controls.Add(this.pl_Login);
            this.flp_root.Location = new System.Drawing.Point(0, 12);
            this.flp_root.Name = "flp_root";
            this.flp_root.Size = new System.Drawing.Size(342, 275);
            this.flp_root.TabIndex = 0;
            this.flp_root.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_root_Paint);
            // 
            // pl_usertype
            // 
            this.pl_usertype.Controls.Add(this.tb_username);
            this.pl_usertype.Controls.Add(this.lb_username);
            this.pl_usertype.Location = new System.Drawing.Point(3, 3);
            this.pl_usertype.Margin = new System.Windows.Forms.Padding(3, 3, 3, 16);
            this.pl_usertype.Name = "pl_usertype";
            this.pl_usertype.Size = new System.Drawing.Size(339, 42);
            this.pl_usertype.TabIndex = 0;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tb_username.Location = new System.Drawing.Point(126, 9);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(169, 29);
            this.tb_username.TabIndex = 2;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_username.Location = new System.Drawing.Point(29, 15);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(94, 23);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "用户类型:";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_username
            // 
            this.pl_username.Controls.Add(this.panel1);
            this.pl_username.Controls.Add(this.lb_password);
            this.pl_username.Controls.Add(this.tb_pwd);
            this.pl_username.Location = new System.Drawing.Point(3, 64);
            this.pl_username.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pl_username.Name = "pl_username";
            this.pl_username.Size = new System.Drawing.Size(342, 39);
            this.pl_username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 13);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(114, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            this.label1.TabStop = true;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_password.Location = new System.Drawing.Point(38, 15);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(58, 15);
            this.lb_password.TabIndex = 0;
            this.lb_password.TabStop = true;
            this.lb_password.Text = "密码：";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_pwd.Location = new System.Drawing.Point(126, 7);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '●';
            this.tb_pwd.Size = new System.Drawing.Size(169, 27);
            this.tb_pwd.TabIndex = 1;
            this.tb_pwd.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // pl_user_tip
            // 
            this.pl_user_tip.Controls.Add(this.lb_user_tip);
            this.pl_user_tip.Location = new System.Drawing.Point(3, 106);
            this.pl_user_tip.Name = "pl_user_tip";
            this.pl_user_tip.Size = new System.Drawing.Size(342, 21);
            this.pl_user_tip.TabIndex = 0;
            // 
            // lb_user_tip
            // 
            this.lb_user_tip.AutoSize = true;
            this.lb_user_tip.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_user_tip.ForeColor = System.Drawing.Color.Red;
            this.lb_user_tip.Location = new System.Drawing.Point(114, 5);
            this.lb_user_tip.Name = "lb_user_tip";
            this.lb_user_tip.Size = new System.Drawing.Size(0, 15);
            this.lb_user_tip.TabIndex = 0;
            this.lb_user_tip.TabStop = true;
            // 
            // pl_password
            // 
            this.pl_password.Controls.Add(this.lb_repassword);
            this.pl_password.Controls.Add(this.tb_repwd);
            this.pl_password.Location = new System.Drawing.Point(3, 130);
            this.pl_password.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pl_password.Name = "pl_password";
            this.pl_password.Size = new System.Drawing.Size(342, 47);
            this.pl_password.TabIndex = 1;
            // 
            // lb_repassword
            // 
            this.lb_repassword.AutoSize = true;
            this.lb_repassword.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_repassword.Location = new System.Drawing.Point(35, 16);
            this.lb_repassword.Name = "lb_repassword";
            this.lb_repassword.Size = new System.Drawing.Size(84, 15);
            this.lb_repassword.TabIndex = 0;
            this.lb_repassword.TabStop = true;
            this.lb_repassword.Text = "重复密码:";
            // 
            // tb_repwd
            // 
            this.tb_repwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_repwd.Location = new System.Drawing.Point(126, 8);
            this.tb_repwd.Name = "tb_repwd";
            this.tb_repwd.PasswordChar = '●';
            this.tb_repwd.Size = new System.Drawing.Size(169, 27);
            this.tb_repwd.TabIndex = 0;
            this.tb_repwd.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // pl_psw_tip
            // 
            this.pl_psw_tip.Controls.Add(this.lb_psw_tip);
            this.pl_psw_tip.Location = new System.Drawing.Point(3, 177);
            this.pl_psw_tip.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.pl_psw_tip.Name = "pl_psw_tip";
            this.pl_psw_tip.Size = new System.Drawing.Size(342, 29);
            this.pl_psw_tip.TabIndex = 0;
            // 
            // lb_psw_tip
            // 
            this.lb_psw_tip.AutoSize = true;
            this.lb_psw_tip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_psw_tip.ForeColor = System.Drawing.Color.Red;
            this.lb_psw_tip.Location = new System.Drawing.Point(114, 3);
            this.lb_psw_tip.Name = "lb_psw_tip";
            this.lb_psw_tip.Size = new System.Drawing.Size(0, 15);
            this.lb_psw_tip.TabIndex = 0;
            this.lb_psw_tip.TabStop = true;
            // 
            // pl_Login
            // 
            this.pl_Login.Controls.Add(this.bt_register);
            this.pl_Login.Location = new System.Drawing.Point(3, 211);
            this.pl_Login.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pl_Login.Name = "pl_Login";
            this.pl_Login.Size = new System.Drawing.Size(342, 47);
            this.pl_Login.TabIndex = 2;
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.SystemColors.Control;
            this.bt_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_register.FlatAppearance.BorderSize = 0;
            this.bt_register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_register.ForeColor = System.Drawing.Color.White;
            this.bt_register.Location = new System.Drawing.Point(49, 5);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(236, 34);
            this.bt_register.TabIndex = 1;
            this.bt_register.Text = "注册";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            this.bt_register.Paint += new System.Windows.Forms.PaintEventHandler(this.bt_Login_Paint);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 283);
            this.Controls.Add(this.flp_root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegister_KeyDown);
            this.flp_root.ResumeLayout(false);
            this.pl_usertype.ResumeLayout(false);
            this.pl_usertype.PerformLayout();
            this.pl_username.ResumeLayout(false);
            this.pl_username.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pl_user_tip.ResumeLayout(false);
            this.pl_user_tip.PerformLayout();
            this.pl_password.ResumeLayout(false);
            this.pl_password.PerformLayout();
            this.pl_psw_tip.ResumeLayout(false);
            this.pl_psw_tip.PerformLayout();
            this.pl_Login.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// 设置登录按钮圆角
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bt_Login_Paint(object sender, PaintEventArgs e)
        {
            UiUtil.Draw(e.ClipRectangle, e.Graphics, 20, false, Color.FromArgb(0, 163, 255), Color.FromArgb(0, 163, 255));
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString("登录", new Font("新宋体", 9F, FontStyle.Regular), new SolidBrush(Color.White), new PointF(72, 8));
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tb_username;
        private TextBox tb_pwd;
    }
}