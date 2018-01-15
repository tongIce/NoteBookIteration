using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALFactory;
using IDAL;
using Model;
using System.Data;

namespace BLL
{
    public class NoteClassifyManage
    {
        static AbstractFactory Factory = AbstractFactory.CreateFactory();
        static IAdminInfoService adminIais = Factory.CreateIAdminInfoService();
        static INoteClassifyServices classIais = Factory.CreateIClassifyService();

        public int UserId()
        {
            AdminInfo admin = new AdminInfo();
            admin.UserName = Common.Username;
            admin.PassWord = Common.Pwd;
            
            return 1;
        }

        #region 新增分类
        public bool AddClass(string classname,int upid)
        {
            if (classIais.AddClass(UserId(), classname,upid) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 删除分类
        public bool DelClass(int id)
        {
            if (classIais.DelClass(id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 修改分类
        public bool UpdateClass(int id, string newclassname)
        {
            if (classIais.UpdateClass(id, newclassname) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 查询分类
        public DataTable SelectClass()
        {
            return classIais.SelectClass(UserId());
        }
        public DataTable SelectClass(string upId)
        {
            return classIais.SelectClass(UserId(),upId);
        }
        #endregion
    }
}
