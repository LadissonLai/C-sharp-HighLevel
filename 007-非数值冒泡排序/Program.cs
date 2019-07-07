using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_非数值冒泡排序
{
    class Program
    {
        static void CommonSort<T>(T[] myArray, Func<T, T, bool> comparison)
        {
            bool flag;
            do
            {
                flag = false;
                for(int i = 0; i < myArray.Length - 1; i++)
                {
                    if (comparison(myArray[i], myArray[i + 1]))
                    {
                        T temp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = temp;
                        flag = true;
                    }
                }
            } while (flag);
        }
        static void Main(string[] args)
        {
            Employee[] employees = 
            {
                new Employee("ladisson",100000),
                new Employee("张三",500),
                new Employee("lsi",600),
                new Employee("wanger",5000),
                new Employee("xiaoming",4203)
            };
            CommonSort<Employee>(employees, Employee.Compare);
            foreach(Employee temp in employees)
            {
                Console.WriteLine(temp.Name + ":" + temp.Salary);
            }
            Console.ReadKey();
        }
    }
}
