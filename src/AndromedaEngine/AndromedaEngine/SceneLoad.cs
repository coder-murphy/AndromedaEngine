using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndromedaEngine;

namespace AndromedaEngine.Entry
{
    public class SceneLoadProc : Singleton<SceneLoadProc>
    {
        /// <summary>
        /// 中心引擎
        /// </summary>
        public static void RunEngine()
        {
            
        }

        /// <summary>
        /// 添加游戏对象
        /// </summary>
        public static void AddObject(GameObject gameObject)
        {
            if (GameObjects == null)
                GameObjects = new List<GameObject>();
            GameObjects.Add(gameObject);
        }

        private static List<GameObject> GameObjects = null;
    }
}
