using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class NoteBookServices:INoteInfoServices
    {

        #region 新增笔记
        public int AddNote(int classifyId, string notes, string time)
        {
            string addsql = "insert into Notes(Notes,Time,ClassifyId) values(@Notes,@Time,@ClassifyId)";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@Notes",notes),new SqlParameter("@Time",time),new SqlParameter("@ClassifyId",classifyId)
            };
            return DBHelper.ExecuteNonQuery(addsql, pam);
        }
        #endregion


        #region 新增笔记
        public int AddNote(int classifyId, string title,string notes, string time)
        {
            string addsql = "insert into Notes(Notes,Time,ClassifyId,title) values(@Notes,@Time,@ClassifyId,@title)";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@Notes",notes),new SqlParameter("@Time",time),new SqlParameter("@ClassifyId",classifyId),new SqlParameter("@title",title)
            };
            return DBHelper.ExecuteNonQuery(addsql, pam);
        }
        #endregion

        #region 删除笔记
        public int DelNote(int id)
        {
            string delsql = "delete Notes where ID=@id";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@id",id)
            };
            return DBHelper.ExecuteNonQuery(delsql, pam);
        }
        #endregion

        #region 修改笔记
        public int UpdateNote(int id, string notes, string time)
        {
            string updasql = "update Notes set Notes=@Notes,Time=@time where ID=@id";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@Notes",notes),new SqlParameter("@id",id),new SqlParameter("@time",time)
            };
            return DBHelper.ExecuteNonQuery(updasql, pam);
        }
        #endregion

        #region 查询笔记
        public DataTable SelectNote(int classifyId)
        {
            string selectsql = "select * from Notes where ClassifyId=@ClassifyId";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@ClassifyId",classifyId)
            };
            return DBHelper.Table(selectsql, pam);
        }
        #endregion

        #region 打开笔记
        public DataTable OpenNote(int id)
        {
            string selectsql = "select Notes,title from Notes where ID=@id";
            SqlParameter[] pam = new SqlParameter[] {
                new SqlParameter("@id",id)
            };
            return DBHelper.Table(selectsql, pam);
        }
        #endregion
    }
}
