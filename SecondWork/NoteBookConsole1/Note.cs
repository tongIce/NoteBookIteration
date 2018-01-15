using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NoteBookConsole1
{
    class Note
    {
        //保存笔记
        public void SaveNote(Object sender, EventArgs e)
        {
            Console.WriteLine("笔记已全部成功保存！");
        }
        //打开笔记
        public void OpenNote(Object sender, EventArgs e)
        {
            Console.WriteLine("请输入要打开笔记的路径：file path: ");
            string PATH = null;
            PATH = Console.ReadLine();
            Console.WriteLine("笔记内容为：");
            StreamReader r = File.OpenText(PATH);
            while (!r.EndOfStream)
                Console.WriteLine(r.ReadLine());
        }
        //新建笔记
        public void NewNote(Object sender, EventArgs e)
        {
            Console.WriteLine("请输入笔记内容：");
            string text = Console.ReadLine();
            string type = "笔记";
            Save(text, type);
        }
        public void Save(string text, string type)
        {
            Console.WriteLine("是否保存{0}？（Y/N）", type);
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                string PATH = null;
                Console.WriteLine("请输入要保存{0}的路径：file path: ", type);
                PATH = Console.ReadLine();
                File.WriteAllText(PATH, text, System.Text.Encoding.UTF8);
                Console.WriteLine("{0}已成功保存！", type);
            }
            else
                Console.WriteLine("已放弃保存{0}！", type);
        }
        //返回主菜单或者退出
        public void ReturnOrQuit(Object sender, EventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("                *******************************************");
            Console.WriteLine("                *              1.返回主菜单界面           *");
            Console.WriteLine("                *              2.退出笔记本               *");
            Console.WriteLine("                *******************************************");
            Console.WriteLine("请输入您要进行的操作:");
            Menu menu = new Menu();
            Function function = new Function();
            OptionFunction optionfunction = new OptionFunction();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    function.NoteEvent += menu.Display;
                    function.Functioning(); break;
                case 2:
                    Console.WriteLine("已退出笔记本,欢迎下次使用!"); break;
                default:
                    function.NoteEvent += menu.Display;
                    function.Functioning();
                    Console.WriteLine("您输入的数字有误，已返回主菜单界面，请输入正确的数字!");
                    optionfunction.Option();
                    break;
            }
        }

    }
}
