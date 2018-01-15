using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                  ******************************************");
            Console.WriteLine("                  *    1:新建笔记          2:打开笔记      *");
            Console.WriteLine("                  *    3:新建分类          4:管理分类      *");
            Console.WriteLine("                  *    5:保存笔记          6:退出          *");
            Console.WriteLine("                  ******************************************");
            Console.WriteLine("请输入菜单选项（1-6）：");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Newnote newnotebook = new Newnote();
                    newnotebook.Newnotebook(); break;
                case "2":
                    Opennote opennotebook = new Opennote();
                    opennotebook.Open(); break;
                case "3":
                    NewClassify newclassify = new NewClassify();
                    newclassify.Classify(); break;
                case "4":
                    Manage managenote = new Manage();
                    Console.WriteLine("                  ******************************************");
                    Console.WriteLine("                  **                 01.查看分类          **");
                    Console.WriteLine("                  **                 02.修改分类          **");
                    Console.WriteLine("                  **                 03.删除分类          **");
                    Console.WriteLine("                  **                 04.保存分类          **");
                    Console.WriteLine("                  ******************************************");
                    Console.WriteLine("请输入菜单选项（01-04）：");
                    string select = Console.ReadLine();
                    switch (select)
                    {
                        case "01":
                            managenote.Open(); break;
                        case "02":
                            managenote.Alter(); break;
                        case "03":
                            managenote.Delete(); break;
                        case "04":
                            managenote.Savenote(); break;
                    } break;
                case "5":
                    Savenote savenote = new Savenote();
                    savenote.Save(); break;
                case "6":
                    Console.WriteLine("退出程序！"); break;
                default:
                    Console.WriteLine("输入错误，请重新输入！"); break;
            }
            Console.ReadLine();
        }
    }
}

