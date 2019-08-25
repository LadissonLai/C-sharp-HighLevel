using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_Main函数测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{args.Length} conmmand line arguments were specified:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
        }
    }
}
