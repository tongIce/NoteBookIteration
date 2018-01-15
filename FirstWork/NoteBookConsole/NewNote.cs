using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Notebook
{
    class Newnote : ISave
    {
        public void Newnotebook()
        {
            Console.WriteLine("请输入笔记内容：");
            string newnote = Console.ReadLine();
            Save(newnote);
        }

        public void Save(string text)
        {
            Console.WriteLine("是否保存笔记？（Y/N）");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                string PATH = null;
                Console.WriteLine("请输入要保存笔记的路径：file path: "); //这里输入文本所在目录 例如 d:\text.txt
                PATH = Console.ReadLine();
                File.WriteAllText(PATH, text, System.Text.Encoding.UTF8);
                Console.WriteLine("笔记已成功保存！");
            }
            else
                Console.WriteLine("已放弃保存笔记！");
        }
    }
}
