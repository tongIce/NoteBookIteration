using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using Model;
using System.Data;

namespace DAL
{
    public class UserInfoServices : IAdminInfoService
    {
        /// <summary>
        /// 实例化DBHelper
        /// </summary>
        private DBHelper db = null;

        public UserInfoServices() {
            db = DBHelper.getInstance();
        }

        /// <summary>
        /// 由账号密码查询管理员信息，验证登陆
        /// </summary>
        /// <param name="a">AdminInfo实体</param>
        /// <returns>查询到的用户信息</returns>
        public AdminInfo SelectAdminInfo(AdminInfo admininfo)
        {
            bool isConn = db.chkConnection();
            if (isConn)
            {
                string sqlGetAdmin = @"select * from Users where Username = '"+admininfo.UserName+"' and PassWord = '"+admininfo.PassWord+"'";
                DataSet ds = db.ExcuteQuery(sqlGetAdmin);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DALUtil.Output(this, ds.Tables[0].Rows[0][0].ToString());
                    admininfo.Uid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    return admininfo;
                }
                else
                    return null;
            }
            else 
                return null;
        }

        public int InsertAdminInfo(AdminInfo a)
        {
            try
            {
                string sql = string.Format("insert into AdminInfo values('{0}','{1}')", a.UserName, a.PassWord);
                return db.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AdminInfo> SelectAllAdminInfo()
        {
            List<AdminInfo> list = new List<AdminInfo>();
            string sql = "select * from AdminInfo";
            DataSet ds = db.ExcuteQuery(sql);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                AdminInfo ai = new AdminInfo
                {
                    Uid = Convert.ToInt32(dr["Uid"]),
                    UserName = dr["UserName"].ToString(),
                    
                };
                list.Add(ai);
            }
            return list;
        }

        public int UpdateAdminInfo(AdminInfo admininfo)
        {
            return 0;
        }

        public int DeleteAdminInfo(AdminInfo admininfo)
        {
            return 0;
        }
    }
}
