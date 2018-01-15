using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BLL
{
    public class BLLUtil
    {
        public static void Output(object obj, string str)
        {
            Debug.WriteLine("---------------------------------------------------------------------------");
            Debug.WriteLine("Debug日志---> " + obj.ToString() + " " + str);
            Debug.WriteLine("---------------------------------------------------------------------------");
        }
    }
}
