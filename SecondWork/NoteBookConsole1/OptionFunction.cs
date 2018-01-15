using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBookConsole1
{
    class OptionFunction
    {
        public void Option()
        {
            //对于不同的菜单操作调用不同的方法      
            Note note = new Note();
            Manage manage = new Manage();
            Function function = new Function();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    //新建笔记
                    function.NoteEvent += note.NewNote;
                    //选择返回主菜单或者退出
                    function.NoteEvent += note.ReturnOrQuit;
                    function.Functioning(); break;
                case 2:
                    Console.Clear();
                    //打开笔记
                    function.NoteEvent += note.OpenNote;
                    //选择返回主菜单或者退出
                    function.NoteEvent += note.ReturnOrQuit;
                    function.Functioning(); break;
                case 3:
                    Console.Clear();
                    //新建分类
                    function.NoteEvent += manage.NewClassify;
                    //选择返回主菜单或者退出
                    function.NoteEvent += note.ReturnOrQuit;
                    function.Functioning(); break;
                case 4:
                    Console.Clear();
                    //管理分类
                    function.NoteEvent += manage.Management;
                    //选择返回主菜单或者退出
                    function.NoteEvent += note.ReturnOrQuit;
                    function.Functioning();
                    break;
                case 5:
                    Console.Clear();
                    //保存笔记
                    function.NoteEvent += note.SaveNote;
                    //选择返回主菜单或者退出
                    function.NoteEvent += note.ReturnOrQuit;
                    function.Functioning();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("笔记本程序退出，谢谢您的使用！");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("输入错误，请重写输入1-6之间的数字！");
                    break;
            }
        }
    }

}

