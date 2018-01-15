using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALFactory;
using Model;
using IDAL;
using System.Data;

namespace BLL
{
    public class NoteManage
    {
        /// <summary>
        /// 根据数据库类型以及当前功能类型创建工厂及服务
        /// </summary>
        static AbstractFactory Factory = AbstractFactory.CreateFactory();
        static INoteInfoServices noteIais = Factory.CreateINoteBookInfoService();

        #region 新增笔记
        public bool AddNote(int classifyId, string notes, string time)
        {
            if (noteIais.AddNote(classifyId, notes, time) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 删除笔记
        public bool DelNote(int id)
        {
            if (noteIais.DelNote(id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 修改笔记
        public bool UpdateClass(int id, string notes, string time)
        {
            if (noteIais.UpdateNote(id, notes, time) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 查询笔记
        public DataTable SelectNote(int classifyId)
        {
            return noteIais.SelectNote(classifyId);
        }
        #endregion

        #region 打开笔记
        public DataTable OpenNote(int id)
        {
            return noteIais.OpenNote(id);
        }
        #endregion
    }

}
