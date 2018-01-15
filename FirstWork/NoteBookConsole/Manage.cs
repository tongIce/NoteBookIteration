using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Notebook
{
    class Manage : ISave, IOpen
    {
        public void Savenote()
        {
            Console.WriteLine("请输入要保存的管理分类内容：");
            string newmanage = Console.ReadLine();
            Save(newmanage);
        }
        public void Save(string text)
        {
            Console.WriteLine("是否保存管理分类内容？（Y/N）");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                File.WriteAllText(@"H:\笔记保存\笔记分类管理列表.txt", text, System.Text.Encoding.UTF8);
                Console.WriteLine("分类管理已成功保存！");
            }
            else
                Console.WriteLine("已放弃保存分类管理！");
        }

        public void Open()
        {
            Console.WriteLine("笔记分类列表为：");
            StreamReader r = File.OpenText(@"G:\保存笔记\笔记分类列表.txt");
            while (!r.EndOfStream)
                Console.WriteLine(r.ReadLine());
        }
        public void Alter()
        {
            Console.WriteLine("分类修改成功！");
        }

        public void Delete()
        {
            Console.WriteLine("分类删除成功！");
        }
    }
}



