using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class NoteClassifyServices : INoteClassifyServices
    {
        #region 新增分类
        public int AddClass(int usersId, string classname,int upid)
        {
            if (upid < 0)
            {
                string addsql = "insert into Classify(UsersId,ClassName,upperId) values( " + usersId + ",'" + classname + "'," + "NULL" + ")";
                return DBHelper.ExecuteNonQuery(addsql);
            }
            else
            {
                string addsql = "insert into Classify(UsersId,ClassName,upperId) values( " + usersId + ",'" + classname + "'," + upid + ")";
                return DBHelper.ExecuteNonQuery(addsql);
            }

            
            //if (upid >= 0)
            //{
            //    SqlParameter[] pam = new SqlParameter[] {
            //    new SqlParameter("@usersId",usersId),new SqlParameter("@classname",classname),new SqlParameter("@upperid",upid)
            //};
                           
            //}
            //else {
            //    SqlParameter[] pam = new SqlParameter[] {
            //    new SqlParameter("@usersId",usersId),new SqlParameter("@classname",classname),new SqlParameter("@upperid",null)};
            //    return DBHelper.ExecuteNonQuery(addsql); 
            //}
            
            
        }
        #endregion

        #region 删除分类
        public int DelClass(int id)
        {
            string delsql = "delete Classify where ID=@id";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@id",id)
            };
            return DBHelper.ExecuteNonQuery(delsql, pam);
        }
        #endregion

        #region 修改分类
        public int UpdateClass(int id, string newclassname)
        {
            string updasql = "update Classify set ClassName=@newclassname where ID=@id";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@newclassname",newclassname),new SqlParameter("@id",id)
            };
            return DBHelper.ExecuteNonQuery(updasql, pam);
        }
        #endregion

        #region 查询分类
        public DataTable SelectClass(int usersId)
        {
            string selectsql = "select id,ClassName,upperid from Classify where UsersId= '1'";
            SqlParameter[] pam = new SqlParameter[] {

                new SqlParameter("@usersId",usersId)
            };
            return DBHelper.Table(selectsql, pam);
        }
        public DataTable SelectClass(int usersId,string upId)
        {
            string selectsql = "select id,ClassName from Classify where UsersId= '1' and id = "+upId;
            return DBHelper.Table(selectsql);
        }

        #endregion
    }
}
