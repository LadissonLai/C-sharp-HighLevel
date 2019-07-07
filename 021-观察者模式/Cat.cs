using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_观察者模式
{
    class Cat
    {
        private string name, color;
        //定义一个猫来了的事件
        public event Action CatComeEvent;
        //构造函数
        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void CatCome()
        {
            Console.WriteLine("我是一只猫，叫做{0}，颜色是{1}", name, color);
            if(CatComeEvent != null)
            {
                CatComeEvent();
            }
        }
    }
}
