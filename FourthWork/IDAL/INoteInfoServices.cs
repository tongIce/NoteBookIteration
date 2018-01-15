using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace IDAL
{
    public interface INoteInfoServices
    {
        ///// <summary>
        ///// 新建笔记
        ///// </summary>
        ///// <param name="notebook">笔记</param>
        ///// <returns>执行命令受影响行数</returns>
        //int AddNote(Note notebook);

        ///// <summary>
        ///// 修改笔记
        ///// </summary>
        ///// <param name="notebook">笔记</param>
        ///// <returns>执行命令受影响行数</returns>
        //int UpdateNote(Note notebook);
        ///// <summary>
        ///// 删除笔记
        ///// </summary>
        ///// <param name="notebook">笔记</param>
        ///// <returns>执行命令受影响行数</returns>
        //int DeleteNote(Note notebook);

        /// <summary>
        /// 添加笔记
        /// </summary>
        /// <param name="classifyId"></param>
        /// <param name="notes"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        int AddNote(int classifyId, string notes, string time);

        /// <summary>
        /// 删除笔记
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelNote(int id);

        
        /// <summary>
        /// 更新笔记
        /// </summary>
        /// <param name="id"></param>
        /// <param name="notes"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        int UpdateNote(int id, string notes, string time);


        /// <summary>
        /// 查询笔记
        /// </summary>
        /// <param name="classifyId"></param>
        /// <returns></returns>
        DataTable SelectNote(int classifyId);

        /// <summary>
        /// 打开笔记
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable OpenNote(int id);
    }
}
