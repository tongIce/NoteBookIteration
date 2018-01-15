using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DAL
{
    class DALUtil
    {
        public static void Output(object obj, string str)
        {
            Debug.WriteLine("---------------------------------------------------------------------------");
            Debug.WriteLine("Debug日志---> " + obj.ToString() + " " + str);
            Debug.WriteLine("---------------------------------------------------------------------------");
        }
    }
}

