using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;
using System.Configuration;

namespace NoteBookUI
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /*
         * hWnd：指定产生动画的窗口的句柄。
         * dwTime：指明动画持续的时间（以微秒计），完成一个动画的标准时间为200微秒。
         */
        //标志描述：
        const int AW_SLIDE = 0x40000;//使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
        const int AW_ACTIVATE = 0x20000;//激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
        const int AW_BLEND = 0x80000;//使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
        const int AW_HIDE = 0x10000;//隐藏窗口，缺省则显示窗口。(关闭窗口用)
        const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
        const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。

        //程序启动，加载验证码
        private void From_ManageLogin_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 700, AW_CENTER);
            yanzhengma();
        }

        private void From_ManageLogin_Paint(object sender, PaintEventArgs e)
        {
            //GraphicsPath Myformpath = new GraphicsPath();      //创建一个路径对象
            //Myformpath.AddEllipse(0 + 10, 0 + 20, this.Width - 20, this.Height - 30);
            ////使用椭圆构造一个区域，并将此区域作为程序窗体区域
            //this.Region = new Region(Myformpath);
        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        public void yanzhengma()
        {
            string yzm = "";
            Random rd = new Random();
            for (int i = 0; i < 4; i++)
            {
                yzm += rd.Next(10).ToString();
            }
            lbl_yzm.Text = yzm;
        }

        /// <summary>
        /// 清空输入框，并注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, EventArgs e)
        {
            frmRegister registe = new frmRegister();
            DialogResult result = registe.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Visible = false;
                MainForm main = new MainForm();
                main.Show();
            }
        }

        /// <summary>
        /// 加载验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yanzhengma();
        }

        /// <summary>
        /// 登陆密码加密
        /// </summary>
        /// <param name="s">明文密码</param>
        /// <returns>加密后的密码</returns>
        private string jiami(string s)
        {
            Encoding ascii = Encoding.ASCII;
            string EncryptString;
            EncryptString = "";
            for (int i = 0; i < s.Length; i++)
            {
                int j;
                byte[] b = new byte[1];
                j = Convert.ToInt32(ascii.GetBytes(s[i].ToString())[0]);
                j = j + 6;
                b[0] = Convert.ToByte(j);
                EncryptString = EncryptString + ascii.GetString(b);
            }

            //如果密码中有'则换成9
            string pwd1 = EncryptString.Replace("'", "9");
            string pwd2 = pwd1.Replace("-", "9");
            string pwd3 = pwd2.Replace("/", "9");
            string newpwd = pwd3.Replace(" ", "9");
            return newpwd;
        }

        /// <summary>
        /// 32位MD5二次加密密码
        /// </summary>
        /// <param name="str">第一次加密后的密码</param>
        /// <returns>32位二次加密密码<returns>
        public static string GetMD5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.UTF8.GetBytes(str);
            byte[] md5b = md5.ComputeHash(b);
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (var item in md5b)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginSysTem();
        }

        public void LoginSysTem()
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("请输入用户名", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_pwd.Text == "")
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_yanzhengma.Text == lbl_yzm.Text)
            {
                //实例化Admininfo对象
                AdminInfo ai = new AdminInfo();

                ai.UserName = txt_name.Text;

                ai.PassWord = txt_pwd.Text;

                //执行查询，验证登陆账号密码
                AdminInfo msg = AdminInfoManage.SelectAdminInfo(ai);

                if (msg != null)
                {
                    frmMain fm = new frmMain("test", "");
                    //Common.Username = msg.UserName;
                    Common.Username = "test";
                    Common.Pwd = "";
                    //Common.Pwd = msg.PassWord;
                    fm.Show();
                    MessageBox.Show("登陆成功");
                    notifyIcon1.Visible = false;
                    this.Visible = false;
                }
                else
                {
                    txt_name.Text = "";
                    txt_pwd.Text = "";
                    txt_yanzhengma.Text = "";
                    yanzhengma();
                    MessageBox.Show("用户名或密码错误", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txt_yanzhengma.Text = "";
                yanzhengma();
                MessageBox.Show("验证码错误", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            //退出系统
            System.Environment.Exit(0);
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 设置验证码输入框只能输入数字
        /// </summary>
        private void txt_yanzhengma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20)
            {
                e.KeyChar = (char)0;  //禁止空格键
            }
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) //处理负数
            {
                return;
            }

            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void lbl_yzm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yanzhengma();
        }

        private void txt_yanzhengma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginSysTem();
            }
        }

        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("http://Seay.sinaapp.com/");
            Sys_Help sh = new Sys_Help();
            sh.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Exit(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.contextMenuStrip2.Show(pictureBox2,e.Location);
            }
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 关于系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sys_Help sh = new Sys_Help();
            sh.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        

        

        






    }
}
