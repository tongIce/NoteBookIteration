using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Common
    {
        private static int userId=1;
        public static int UserId
        {
            get { return Common.userId; }
            set { Common.userId = value; }
        }

        private static string username = "";
        public static string Username
        {
            get { return Common.username; }
            set { Common.username = value; }
        }

        private static string pwd = "";
        public static string Pwd
        {
            get { return Common.pwd; }
            set { Common.pwd = value; }
        }

    }
}
