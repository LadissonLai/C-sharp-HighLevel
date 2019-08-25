using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_多态测试
{
    class Son : Father
    {
        public Son()
        {
            
        }

        public override void BrilliantSkill()
        {
            //base.BrilliantSkill();
            Console.WriteLine($"我是儿子{Name}，我在使用独门绝技");
        }
        public void DanShouFuWoCheng()
        {
            Console.WriteLine($"我是儿子{Name}，我会单手俯卧撑");
        }
    }
}
