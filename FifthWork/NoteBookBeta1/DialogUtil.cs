using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace NoteBookUI
{
    class DialogUtil
    {
        public static String filename;
        public static bool bIsSave = false;


        /// <summary>
        /// 改变字体大小
        /// </summary>
        /// <param name="fontDialog">字体变化的Dialog</param>
        /// <param name="richTextBox">需要控制改变字体的控件</param>
        public static void FontSizeChange(FontDialog fontDialog, RichTextBox richTextBox)
        {
            fontDialog = new FontDialog();
            fontDialog.Color = richTextBox.ForeColor;
            fontDialog.AllowScriptChange = true;
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.SelectionFont = fontDialog.Font;//将当前选定的文字改变字体
            }
        }


        /// <summary>
        /// 改变字体颜色
        /// </summary>
        /// <param name="colorDialog">字体颜色变化的Dialog</param>
        /// <param name="richTextBox">需要控制改变字体的控件</param>
        public static void FontColorChange(ColorDialog colorDialog, RichTextBox richTextBox)
        {
            colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = Color.Black;//初始化当前文本框中的字体颜色，当用户在ColorDialog对话框中点击"取消"按钮
            //file://恢复原来的值
            colorDialog.ShowDialog();
            richTextBox.SelectionColor = colorDialog.Color;
        }


        /// <summary>
        /// 文件另存为
        /// </summary>
        /// <param name="saveFileDialog">保存Dialog</param>
        /// <param name="richTextBox">需要控制的控件</param>
        public static void FileSaveAs(SaveFileDialog saveFileDialog, RichTextBox richTextBox)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "*.txt";
            saveFileDialog.Filter = "文本文档(*.txt)|*.txt";
            saveFileDialog.Title = "保存";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                filename = saveFileDialog.FileName;
                richTextBox.Clear();
            }
            bIsSave = true;
        }


        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="openFileDialog">打开Dialog</param>
        /// <param name="richTextBox">需要控制的控件</param>
        public static void OpenFile(OpenFileDialog openFileDialog, RichTextBox richTextBox)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "*.txt";
            openFileDialog.Filter = "文本文档(*.txt)|*.txt|所有文件|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default);
                richTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            filename = openFileDialog.FileName;
            bIsSave = true;
        }
    }
}
