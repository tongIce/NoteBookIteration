using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALFactory;
using IDAL;
using Model;

namespace BLL
{
    public class AdminInfoManage
    {
        /// <summary>
        /// 根据数据库类型以及当前功能类型创建工厂及服务
        /// </summary>
        static AbstractFactory Factory = AbstractFactory.CreateFactory();
        static IAdminInfoService Iais = Factory.CreateIAdminInfoService();

        public static AdminInfo SelectAdminInfo(AdminInfo tempAdmin) 
        {
            return Iais.SelectAdminInfo(tempAdmin);
        }
        public static bool InsertAdmin(AdminInfo admin) {
            if (Iais.InsertAdminInfo(admin) != 0)
                return true;
            else
                return false;
        }

    }
}
