using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom", "blue");
            Mouse mouse1 = new Mouse("Tony", cat);
            Mouse mouse2 = new Mouse("Whisky", cat);
            cat.CatCome();
            Console.ReadKey();
        }
    }
}
