using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBookConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用Menu类中的show()输出主菜单界面
            Menu mymenu = new Menu();
            Function myfunction = new Function();
            OptionFunction optionfunction = new OptionFunction();

            myfunction.NoteEvent += mymenu.Display;
            myfunction.Functioning();
            optionfunction.Option();
            //调用Menu类中的Function()对于不同的菜单操作调用不同的方法
            Console.ReadLine();
        }
    }

}
