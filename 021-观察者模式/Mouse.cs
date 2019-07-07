using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_观察者模式
{
    class Mouse
    {
        private string name;
        public Mouse(string name,Cat cat)
        {
            this.name = name;
            cat.CatComeEvent += this.RunAway;
        }
        public void RunAway()
        {
            Console.WriteLine("猫来了，{0}赶紧跑了",this.name);
        }
    }


}
