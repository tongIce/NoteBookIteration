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
        public int AddClass(int usersId, string classname)
        {
            string addsql = "insert into Classify(UsersId,ClassName) values(@usersId,@classname)";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@usersId",usersId),new SqlParameter("@classname",classname)
            };
            return DBHelper.ExecuteNonQuery(addsql, pam);
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
            string selectsql = "select * from Classify where UsersId=@usersId";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@usersId",usersId)
            };
            return DBHelper.Table(selectsql, pam);
        }
        #endregion
    }
}
