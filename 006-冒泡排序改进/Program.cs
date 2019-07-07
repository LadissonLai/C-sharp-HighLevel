using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_冒泡排序改进
{
    class Program
    {
        static void proBubbleSort(int[] array)
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
                }
            } while(flag);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 12, -23, 45, 2, 9, 78 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            proBubbleSort(myArray);
            Console.WriteLine();
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
