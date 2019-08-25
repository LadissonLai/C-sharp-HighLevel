using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_多态测试
{
    class Father
    {
        public string Name { get; set; }
        public virtual void BrilliantSkill()
        {
            Console.WriteLine("我是父亲，我在使用独门绝技");
        }
    }
}
