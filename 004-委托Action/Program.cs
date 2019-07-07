using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_委托Action
{
    class Program
    {
        static void PrintSB(string name)
        {
            Console.WriteLine(name + "是SB,hahaha!");
        }
        static void Main(string[] args)
        {
            Action<string> congratulation = PrintSB;   //委托类型的声明，不加括号
            congratulation("家乐福理发店的barber");    //调用的时候才加括号
            Console.ReadKey();
        }
    }
}
