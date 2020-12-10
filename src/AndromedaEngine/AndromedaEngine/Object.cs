using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndromedaEngine
{
    /// <summary>
    /// 所有对象的基类
    /// </summary>
    public class Object
    {
        /// <summary>
        /// 销毁这个对象
        /// </summary>
        public virtual void Destroy()
        {
            Destroy(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Destroy(bool disposing)
        {
            if (IsDestroy == false)
            {
                if (disposing)
                {
                    // TODO: 销毁托管资源
                }
                // TODO: 销毁非托管资源
                IsDestroy = true;
            }
        }

        /// <summary>
        /// 该对象的唯一标识符
        /// </summary>
        public string Guid { get; private set; } 

        /// <summary>
        /// 指示该对象是否被销毁
        /// </summary>
        public bool IsDestroy { get; private set; }

        ~Object()
        {

        }
    }
}
