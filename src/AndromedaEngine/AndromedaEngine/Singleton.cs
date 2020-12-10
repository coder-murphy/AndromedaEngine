using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndromedaEngine
{
    /// <summary>
    /// 提供单例模式的类
    /// </summary>
    public class Singleton<T> : Object where T : class, new()
    {
        /// <summary>
        /// 指向该模式的单例
        /// </summary>
        protected static T Instance = null;

        protected Singleton(){}

        /// <summary>
        /// 获取当前单例实例
        /// </summary>
        public static T GetInstance()
        {
            if (Instance == null)
                Instance = new T();
            return Instance;
        }
    }
}
