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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.webBrowser1.Navigate("C:/Users/admit/Documents/Visual Studio 2010/Projects/NoteBookBeta1/NoteBookBeta1/Resourses/Editor.html");
        }

        public string nclassname { get; set; }
        DataTable table = new DataTable();
        NoteClassifyManage cb = new NoteClassifyManage();
        NoteManage nb = new NoteManage();
        RichTextBox rt = new RichTextBox();
        int Classid = 0;
        int Noteid = 0;
        //rtf格式“新建笔记---无内容”
        string nocontent = @"{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset134 \'cb\'ce\'cc\'e5;}}
\viewkind4\uc1\pard\lang2052\f0\fs24\'d0\'c2\'bd\'a8\'b1\'ca\'bc\'c7---\'ce\'de\'c4\'da\'c8\'dd\par}";

        //分类管理
        #region
        //加载分类
        public void LoadClass()
        {
            listView1.Clear();
            table = cb.SelectClass();
            listView1.Columns.Add("分类", 200);
            listView1.Sorting = SortOrder.Ascending;
            foreach (DataRow dr in table.Rows)
            {
                ListViewItem first = new ListViewItem(dr["ClassName"].ToString(), 1);
                first.Tag = (int)dr["ID"];
                this.listView1.Items.Add(first);
            }
        }
        #region
        private void frmMian_Load(object sender, EventArgs e)
        {
            LoadClass();
            tbDate.Text = DateTime.Now.ToLongDateString();
        }
        #endregion
        //右击新建分类
        private void NewClass_Click(object sender, EventArgs e)
        {
            ListViewItem first = new ListViewItem("新建分类", 1);
            this.listView1.Items.Add(first);
            //if (cb.AddClass("新建分类"))
            //{
            //    MessageBox.Show("新建分类成功！");
            //    LoadClass();
            //}
            //else
            //{
            //    MessageBox.Show("新建分类失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        //右击重命名分类
        private void ReName_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count > 0)
                {
                    ListView.SelectedIndexCollection lv = this.listView1.SelectedIndices;
                    Classid = (int)this.listView1.Items[lv[0]].Tag;
                }
                frmReClass frm = new frmReClass();
                frm.Owner = this;
                frm.ShowDialog();
                if (nclassname == null && Classid == 0)
                {
                    return;
                }
                else
                {
                    if (cb.UpdateClass(Classid, nclassname) == true)
                    {
                        MessageBox.Show("重命名分类成功！");
                        this.listView1.Clear();
                        LoadClass();
                    }
                    else
                    {
                        MessageBox.Show("重命名分类失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        //删除分类
        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除分类将删除分类下的所有笔记，确定要删除？", "！！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count > 0)
                {
                    ListView.SelectedIndexCollection lv = this.listView1.SelectedIndices;
                    Classid = (int)this.listView1.Items[lv[0]].Tag;
                    this.listView1.Items[lv[0]].Remove();
                    dataGridView1.Rows.Clear();
                }
                if (Classid == 0)
                {
                    return;
                }
                else
                {
                    if (cb.DelClass(Classid) == true)
                    {
                        MessageBox.Show("删除分类成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除分类失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        //笔记管理
        #region
        //加载笔记
        private void Open_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            if (this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection lv = this.listView1.SelectedIndices;
                Classid = (int)this.listView1.Items[lv[0]].Tag;
            }
            //判断是否获取id
            if (Classid == 0)
            {
                return;
            }
            else
            {
                try
                {
                    table = nb.SelectNote(Classid);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("没有笔记！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbNote.Clear();
                    }
                    LoadNote();
                }
                catch
                {
                    return;
                }
            }
        }
        //搜索笔记
        #region
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView daview = new DataGridView();
                table = nb.SelectNote(Classid);
                DataTable dtNew = table.Copy();
                dtNew.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    rt.Rtf = table.Rows[i][1].ToString();
                    DateTime time = (DateTime)table.Rows[i][2];
                    dtNew.Rows.Add(table.Rows[i][0], rt.Text, time.ToString("yyyy/MM/dd"));
                }
                DataRow[] drArr = dtNew.Select("Notes like '%" + txtContent.Text + "%'");
                DataTable dtn = dtNew.Clone();
                for (int i = 0; i < drArr.Length; i++)
                {
                    dtn.ImportRow(drArr[i]);
                }
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dtn.Rows.Count; i++)
                {
                    rt.Text = dtn.Rows[i][1].ToString();
                    DateTime time = (DateTime)dtn.Rows[i][2];
                    if (rt.Text.Length < 20)
                    {
                        dataGridView1.Rows.Add(rt.Text, time.ToString("yyyy/MM/dd"), dtn.Rows[i][0]);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(rt.Text.Replace("\n", "").Substring(0, 20), time.ToString("yyyy/MM/dd"), dtn.Rows[i][0]);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        #endregion
        //单击击打开笔记
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Noteid = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
                }
                table = nb.OpenNote(Noteid);
                foreach (DataRow row in table.Rows)
                {
                    tbNote.Rtf = row["Notes"].ToString();
                }

                tbNote.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        //右击新建笔记
        private void NewNote_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection lv = this.listView1.SelectedIndices;
                Classid = (int)this.listView1.Items[lv[0]].Tag;
            }
            else
            {
                MessageBox.Show("请先选择分类！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nb.AddNote(Classid, nocontent, DateTime.Now.ToString("yyyy-MM-dd")) == true)
            {
                MessageBox.Show("新建笔记成功！");
                table = nb.SelectNote(Classid);
                LoadNote();
            }
            else
            {
                MessageBox.Show("新建笔记失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //右击删除笔记
        private void DelNote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除？", "！！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (Noteid == 0)
                {
                    return;
                }
                else
                {
                    if (nb.DelNote(Noteid) == true)
                    {
                        MessageBox.Show("删除笔记成功！");
                        tbNote.Clear();
                        table = nb.SelectNote(Classid);
                        LoadNote();
                    }
                    else
                    {
                        MessageBox.Show("删除笔记失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                return;
            }
        }
        //保存笔记
        private void SaveNote_Click(object sender, EventArgs e)
        {
            if (nb.UpdateClass(Noteid, tbNote.Rtf, DateTime.Now.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("保存笔记成功！");
                table = nb.SelectNote(Classid);
                LoadNote();
            }
            else
            {
                MessageBox.Show("保存笔记失败，请重试！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //重新加载笔记
        public void LoadNote()
        {
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    rt.Rtf = table.Rows[i][1].ToString();
                    DateTime time = (DateTime)table.Rows[i][2];
                    if (rt.Text.Length < 20)
                    {
                        dataGridView1.Rows.Add(rt.Text, time.ToString("yyyy/MM/dd"), table.Rows[i][0]);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(rt.Text.Replace("\n", "").Substring(0, 20), time.ToString("yyyy/MM/dd"), table.Rows[i][0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //文字的设置
        #region
        private void Fonts_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            tbNote.SelectionFont = fontDialog.Font;
        }
        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            tbNote.SelectionColor = this.colorDialog1.Color;
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            this.tbNote.Copy();
        }
        private void Cut_Click(object sender, EventArgs e)
        {
            this.tbNote.Cut();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            this.tbNote.Paste();
        }
        #endregion 
    }
}
