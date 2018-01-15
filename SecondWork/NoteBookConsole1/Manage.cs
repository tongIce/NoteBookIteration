using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NoteBookConsole1
{
    class Manage
    {
        public void NewClassify(Object sender, EventArgs e)
        {
            Console.WriteLine("请输入新建分类内容：");
            string newclass = Console.ReadLine();
            string type = "分类";
            Note note = new Note();
            note.Save(newclass, type);
        }
        public void OpenClassify()
        {
            Console.WriteLine("请输入要打开分类的路径：file path: ");  //这里输入文本所在目录 例如 d:\text.txt
            string PATH = null;
            PATH = Console.ReadLine();
            Console.WriteLine("分类内容为：");
            StreamReader r = File.OpenText(PATH);
            while (!r.EndOfStream)
                Console.WriteLine(r.ReadLine());
        }
        public void Management(Object sender, EventArgs e)
        {
            Console.WriteLine("                *******************************************");
            Console.WriteLine("                **            01.查看分类                **");
            Console.WriteLine("                **            02.修改分类                **");
            Console.WriteLine("                **            03.删除分类                **");
            Console.WriteLine("                **            04.保存分类                **");
            Console.WriteLine("                **            05.返回主菜单              **");
            Console.WriteLine("                **            06.退出                    **");
            Console.WriteLine("                *******************************************");
            Console.WriteLine("请输入菜单选项（01-06）：");
            Menu menu = new Menu();
            Function function = new Function();
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 01:
                    OpenClassify(); break;
                case 02:
                    Console.WriteLine("修改分类成功！"); break;
                case 03:
                    Console.WriteLine("删除分类成功！"); break;
                case 04:
                    Console.WriteLine("保存分类成功！"); break;
                case 05:
                    function.NoteEvent += menu.Display;
                    function.Functioning(); break;
                case 06:
                    Console.WriteLine("笔记本程序退出，谢谢您的使用！"); break;
                default:
                    Console.WriteLine("输入错误，请重写输入1-6之间的数字！");
                    break;
            }
        }

    }
}
