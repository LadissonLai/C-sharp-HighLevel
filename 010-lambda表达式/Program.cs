using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_lambda表达式
{
    class Program
    {
        static Func<int, int> aa1 = x => x * x;
        static void Main(string[] args)
        {
            //lambda表达式应用:一个数的平方
            
            Func<int, int> aa2 = (y) => { return y * y; };
            Console.WriteLine(aa1(10));

        }
    }
}
