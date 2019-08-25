using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_形参类型测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant xiaofeixiang = new Elephant() { Name = "小飞象", ID = 100 };
            Console.WriteLine(xiaofeixiang.Name);
            Console.WriteLine(xiaofeixiang.ID);
            Console.WriteLine("------调用函数修改引用类型参数是否有影响------");
            ChangeClassItem(xiaofeixiang);
            Console.WriteLine(xiaofeixiang.Name);
            Console.WriteLine(xiaofeixiang.ID);

            int num = 1314;
            Console.WriteLine($"\nnum={num}");
            Console.WriteLine("------调用函数修改值类型参数是否有影响------");
            ChangeIntValue(num);
            Console.WriteLine(num);
            Console.WriteLine("我们使用关键字ref后");
            ChangeIntValue(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }

        static void ChangeClassItem(Elephant elephant)
        {
            elephant.Name = "zhuzhu";
            elephant.ID = 007;
        }

        static void ChangeClassItem(ref Elephant elephant)
        {
            elephant.Name = "zhuzhu";
            elephant.ID = 007;
        }

        static void ChangeIntValue(int item)
        {
            item = 520;
        }
        static void ChangeIntValue(ref int item)
        {
            item = 520;
        }
    }
}
