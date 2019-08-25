using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_多态测试
{
    class GrandSon : Son
    {
        public override void BrilliantSkill()
        {
            //base.BrilliantSkill();
            Console.WriteLine("我是孙子，我在使用独门绝技");
        }
    }
}
