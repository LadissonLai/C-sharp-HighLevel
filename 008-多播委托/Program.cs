using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Main(string[] args)
        {
            //多播委托
            Action aa = Test1;
            aa += Test2;
            aa -= Test1;
            aa();
            Console.ReadKey();
        }
    }
}
