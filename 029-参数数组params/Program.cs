using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_参数数组params
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumResult;
            Console.WriteLine("需要求和的数组是：（1，2，3，4，5）");
            SumArray(out sumResult, 1, 2, 3, 4, 5);
            Console.WriteLine($"求和结果是：{sumResult}");
            Console.ReadKey();
        }
        static void SumArray(out int sumResult,params int[] vals)
        {
            sumResult = 0;
            foreach (var item in vals)
            {
                sumResult += item;
            }
        }
    }
}
