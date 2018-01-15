using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBookConsole1
{
    class Menu
    {
        public void Display(Object sender, EventArgs e)
        {
            //清除界面中已有的全部内容
            Console.Clear();

            //显示主菜单界面
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                *******************************************");
            Console.WriteLine("                *     1:新建笔记         2:打开笔记       *");
            Console.WriteLine("                *     3:新建分类         4:管理分类       *");
            Console.WriteLine("                *     5:保存笔记         6:退出           *");
            Console.WriteLine("                *******************************************");
            Console.WriteLine("请输入菜单选项（1-6）：");
        }

    }
}
