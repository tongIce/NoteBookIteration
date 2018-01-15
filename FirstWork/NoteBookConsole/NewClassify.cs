using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Notebook
{
    class NewClassify : ISave
    {
        public void Classify()
        {
            Console.WriteLine("请输入新建分类内容：");
            string newclass = Console.ReadLine();
            Save(newclass);
        }
        public void Save(string text)
        {
            Console.WriteLine("是否保存新建分类内容？（Y/N）");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                File.WriteAllText(@"G:\保存笔记\笔记分类列表.txt", text, System.Text.Encoding.UTF8);
                Console.WriteLine("新建分类已成功保存！");
            }
            else
                Console.WriteLine("已放弃保存新建分类！");
        }
    }
}
