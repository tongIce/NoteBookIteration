using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AdminInfo
    {
        /*
            Uid int identity(1,1) primary key not null,  --管理员ID
	        UserName nvarchar(20) not null,		--管理员用户名
	        PassWord nvarchar(16) not null		--管理员密码
         */

        /// <summary>
        /// 管理员ID
        /// </summary>
        public int Uid { get; set; }

        /// <summary>
        /// 管理员用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        public string PassWord { get; set; }

       
    }
}
