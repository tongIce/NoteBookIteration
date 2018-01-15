using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using IDAL;

namespace DALFactory
{
    public abstract class AbstractFactory
    {
        ////////反射/////////////////////////////
        //string factoryName = coatType+"Factory";
        //ifactory = (IFactory)Assembly.Load("程序集名称").CreateInstance("Factory.SportFactory");
        /// <summary>
        /// 创建工厂(创建SqlServerFactory)
        /// </summary>
        /// <returns></returns>
        public static AbstractFactory CreateFactory()
        {
            //获取配置文件中的dbType(数据库类型)的值
            string dbType = ConfigurationManager.AppSettings.Get("dbType");

            //加载DALFactory程序集
            Assembly ass = Assembly.Load("DALFactory");

            //通过反射动态创建具体工厂类的实例，返回指向抽象工厂类的引用
            return ass.CreateInstance(string.Format("DALFactory.{0}Factory", dbType)) as AbstractFactory;
        }
        /// <summary>
        /// 创建抽象工厂
        /// </summary>
        /// <returns></returns>
        public abstract IAdminInfoService CreateIAdminInfoService();
        public abstract INoteInfoServices CreateINoteBookInfoService();
        public abstract INoteClassifyServices CreateIClassifyService();
    }
}
