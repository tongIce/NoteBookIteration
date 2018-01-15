using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace NoteBookUI
{
    public partial class frmNewFile : BaseForm
    {
        private NoteClassifyManage classify = new NoteClassifyManage();
        private TreeNode parent;
        private TreeNode node;

        public frmNewFile(TreeNode node)
        {
            this.node = node; 
            InitializeComponent();
        }

        private void frmNewFile_Load(object sender, EventArgs e)
        {

        }
        private void tb_fileName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加文件夹名称，保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_save_Click(object sender, EventArgs e)
        {
            //先检查输入是否为空
            if (tb_fileName.Text != "")
            {
                
                if (node != null ) {
                    bool isInsert = this.classify.AddClass(tb_fileName.Text, int.Parse(node.Name));
                    if (isInsert)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        MessageBox.Show("添加成功！");
                    }
                    else {
                        MessageBox.Show("添加失败，请重试！");
                    }
                }else{
                    this.classify.AddClass(tb_fileName.Text,-1);                    
                }
                //先检查是否已存在该文件夹名字
                //if (!db.CheckNewFile(LoginBean.UserName, tb_fileName.Text))
                //{
                //    db.NewFile(LoginBean.UserName, tb_fileName.Text);
                //    MessageBox.Show("成功添加文件夹名：" + tb_fileName.Text);
                //    tb_fileName.Text = "";
                //    return;
                //}
                //MessageBox.Show("文件夹名字已存在,请重新输入！");
                //return;
            }
            else
            {
                MessageBox.Show("请输入文件夹名！");
                return;
            }
        }

        /// <summary>
        /// 修改密码页面点击No按钮取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_no_Click(object sender, EventArgs e)
        {
            tb_fileName.Text = "";
        }

        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_small_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 关闭此窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
