using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IDAL
{
    public interface IAdminInfoService
    {
        /// <summary>
        /// 验证用户名密码
        /// </summary>
        /// <param name="AdminInfo">管理员信息</param>
        /// <returns>判断返回的admininfo是否为空，不为空则登陆成功</returns>
        AdminInfo SelectAdminInfo(AdminInfo admininfo);

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="admininfo">用户信息</param>
        /// <returns>受影响的行数</returns>
        int InsertAdminInfo(AdminInfo admininfo);

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns>用户集合</returns>
        List<AdminInfo> SelectAllAdminInfo();

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="admininfo">用户信息</param>
        /// <returns>受影响的行数</returns>
        int UpdateAdminInfo(AdminInfo admininfo);

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="admininfo">用户信息</param>
        /// <returns>受影响的行数</returns>
        int DeleteAdminInfo(AdminInfo admininfo);
    }
}
