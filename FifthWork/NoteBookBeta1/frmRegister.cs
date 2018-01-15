using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace NoteBookUI
{
    public partial class frmRegister : BaseForm
    {

        public frmRegister()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /*
         * hWnd：指定产生动画的窗口的句柄。
         * dwTime：指明动画持续的时间（以微秒计），完成一个动画的标准时间为200微秒。
         * dwFags：指定动画类型。这个参数可以是一个或多个下列标志的组合。
         * 返回值：如果函数成功，返回值为非零；如果函数失败，返回值为零。
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
        private void Form1_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 700, AW_CENTER);
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flp_root_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!tb_username.Text.Equals("") && !tb_pwd.Equals("") && !tb_repwd.Equals(""))
                {
                    if (tb_pwd.Text.Equals(tb_repwd.Text))
                    {
                        AdminInfo admin = new AdminInfo();
                        admin.UserName = tb_username.Text;
                        admin.PassWord = tb_pwd.Text;
                        bool isInsert = AdminInfoManage.InsertAdmin(admin);
                        if (!isInsert)
                        {
                            MessageBox.Show("该用户已存在！请重新注册！");
                        }
                        else {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            MessageBox.Show("恭喜您成为新用户！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请保持密码一致！");
                    }
                }
                else
                {
                    MessageBox.Show("请输入有效信息！");
                }
            }
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            if (!tb_username.Text.Equals("") && !tb_pwd.Equals("") && !tb_repwd.Equals(""))
            {
                if (tb_pwd.Text.Equals(tb_repwd.Text))
                {
                    AdminInfo admin = new AdminInfo();
                    admin.UserName = tb_username.Text;
                    admin.PassWord = tb_pwd.Text;
                    bool isInsert = AdminInfoManage.InsertAdmin(admin);
                    if (!isInsert) {
                        MessageBox.Show("该用户已存在！请重新注册！");
                    }
                    else
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        MessageBox.Show("恭喜您成为新用户！");
                    }
                }
                else {
                    MessageBox.Show("请保持密码一致！");
                }
               
            }
            else
            {
                MessageBox.Show("请输入有效信息！");
            }
        }
    }
}
