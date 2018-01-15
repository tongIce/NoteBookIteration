using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALFactory;
using Model;
using IDAL;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace BLL
{
    public class NoteManage : INoteModifyServices
    {
        private ColorDialog colorDialog = new ColorDialog();
        private FontDialog fontDialog = new FontDialog();
        private OpenFileDialog fileDialog = new OpenFileDialog();
        private SaveFileDialog saveDialog = new SaveFileDialog();

        /// <summary>
        /// 根据数据库类型以及当前功能类型创建工厂及服务
        /// </summary>
        static AbstractFactory Factory = AbstractFactory.CreateFactory();
        static INoteInfoServices noteIais = Factory.CreateINoteBookInfoService();

        #region 新增笔记
        public bool AddNote(int classifyId, string notes, string time)
        {
            if (noteIais.AddNote(classifyId, notes, time) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 删除笔记
        public bool DelNote(int id)
        {
            if (noteIais.DelNote(id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 修改笔记
        public bool UpdateClass(int id, string notes, string time)
        {
            if (noteIais.UpdateNote(id, notes, time) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 查询笔记
        public DataTable SelectNote(int classifyId)
        {
            return noteIais.SelectNote(classifyId);
        }
        #endregion

        #region 打开笔记
        public DataTable OpenNote(int id)
        {
            return noteIais.OpenNote(id);
        }
        #endregion


        /// <summary>
        /// 设置字体大小
        /// </summary>
        /// <param name="richTextBox">RichTextBox</param>
        public void setFontSize(RichTextBox richTextBox)
        {
            fontDialog.Color = richTextBox.ForeColor;
            fontDialog.AllowScriptChange = true;
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.SelectionFont = fontDialog.Font;//将当前选定的文字改变字体
            }
        }
        /// <summary>
        /// 设置字体颜色
        /// </summary>
        /// <param name="richTextBox">RichTextBox</param>
        public void setFontColor(RichTextBox richTextBox)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = Color.Black;//初始化当前文本框中的字体颜色，当用户在ColorDialog对话框中点击"取消"按钮
            //file://恢复原来的值
            colorDialog.ShowDialog();
            richTextBox.SelectionColor = colorDialog.Color;
        }
        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="richTextBox">RichTextBox</param>
        public void insertPicture(RichTextBox richTextBox)
        {
            fileDialog.Filter = "bmp文件(*.bmp)|*.bmp|jpg文件（*.jpg）|*.jpg|ico文件(*.ico)|*.ico|png文件|*.png";
            fileDialog.Title = "打开图片";
            fileDialog.FilterIndex = 2;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(fileDialog.FileName);
                Clipboard.SetDataObject(bmp, false);
                if (richTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    richTextBox.Paste();
            }  
        }

        /// <summary>
        /// 保存笔记
        /// </summary>
        /// <param name="textbox">RichTextBox</param>
        public void saveNote(RichTextBox richTextBox)
        {
            //保存RTF格式文件
            saveDialog.Filter="RTF文件(*.rtf)|*.rtf|txt文件(*.txt)|*.txt"; saveDialog.DefaultExt="rtf";//默认的文件扩展名
            if (saveDialog.ShowDialog() == DialogResult.OK) {
                if (saveDialog.FilterIndex == 1) {
                    richTextBox.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
                }
                if (saveDialog.FilterIndex == 2) {
                    richTextBox.SaveFile(saveDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("保存成功！");
            }
                
        }
        public bool saveNote(string id, string title, string content) { 
            //string str_command = "";
            
            if(noteIais.AddNote(int.Parse(id),title,content,DateTime.Now.ToString())!=0)
                return true;

            return false;
        
        }

        /// <summary>
        /// 打开笔记
        /// </summary>
        /// <param name="richTextBox"></param>
        public void openNote(RichTextBox richTextBox)
        {
            string filename = fileDialog.FileName;
            fileDialog.Filter = "文本文件(*.txt)|*.txt|rtf文件(*.*)|*.rtf";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = fileDialog.FileName;
                if (fName.Contains("txt"))
                {
                    richTextBox.LoadFile(fName, RichTextBoxStreamType.PlainText);
                }
                else {
                    if (fName.Contains("rtf"))
                    {
                        richTextBox.LoadFile(fName, RichTextBoxStreamType.RichText);
                    }
                    else {
                        MessageBox.Show("暂不支持该格式文件！");
                    }
                }
            }
        }

    }

}
