using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace DALFactory
{
    class SqlServerFactory : AbstractFactory
    {

        /// <summary>
        /// 创建抽象工厂
        /// </summary>
        /// <returns>用户管理</returns>
        public override IDAL.IAdminInfoService CreateIAdminInfoService()
        {
            return new UserInfoServices();
        }



        /// <summary>
        /// 创建抽象工厂
        /// </summary>
        /// <returns>笔记本管理</returns>
        public override IDAL.INoteInfoServices CreateINoteBookInfoService()
        {
            return new DAL.NoteBookServices();
        }
        /// <summary>
        /// 创建抽象工厂
        /// </summary>
        /// <returns>笔记分类管理</returns>
        public override IDAL.INoteClassifyServices CreateIClassifyService()
        {
            return new DAL.NoteClassifyServices();
        }
    }
}
