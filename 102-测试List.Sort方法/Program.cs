using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_测试List.Sort方法
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> arrayList = new List<float>{ 1.1f, 2.1f, -2.1f, 3.5f };
            arrayList.Sort();  //从小到大排序
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
            arrayList.Reverse();  //元素交换顺序
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();  //clear方法
            foreach (var item in arrayList)
            {
                if (item == 0f)
                {
                    Console.WriteLine("kong");
                }
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
