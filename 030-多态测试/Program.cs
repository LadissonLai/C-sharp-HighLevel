using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_多态测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Father son1 = new Son() { Name = "赵日天" };
            son1.BrilliantSkill();
            //son1.DanShouFuWoCheng()不可用，儿子以父亲的身份出现，自己的属性和方法不能用
            //son1.Name;
            Son son2 = new Son() { Name = "赵日地" };
            son2.BrilliantSkill();
            Console.ReadKey();
        }
    }
}
