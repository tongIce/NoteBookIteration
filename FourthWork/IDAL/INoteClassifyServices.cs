using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace IDAL
{
    public interface INoteClassifyServices
    {
        //添加分类
        int AddClass(int usersId, string classname);

        //删除分类
        int DelClass(int id);

        //更新分类
        int UpdateClass(int id, string newclassname);

        //查询分类
        DataTable SelectClass(int usersId);
    }
}
