using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_委托Func
{
    class Program
    {
        static string Revenger(bool x,string name)
        {
            string res;
            if (x == true)
            {
                res = name + "是一个傻逼。";
            }
            else
            {
                res = name + "死了妈。";
            }
            return res;
        }
        static void Main(string[] args)
        {
            Func<bool, string, string> hooray = Revenger;
            Console.WriteLine(hooray(true, "家乐福的Barber"));
            Console.ReadKey();
        }
    }
}
