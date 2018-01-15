using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Notebook
{
    class Opennote : IOpen
    {
        public void Open()
        {
            string PATH = null;
            Console.WriteLine("请输入要打开笔记的路径：file path: ");  //这里输入文本所在目录 例如 d:\text.txt
            PATH = Console.ReadLine();
            Console.WriteLine("笔记内容为：");
            StreamReader r = File.OpenText(PATH);
            while (!r.EndOfStream)
                Console.WriteLine(r.ReadLine());
        }
    }
}

