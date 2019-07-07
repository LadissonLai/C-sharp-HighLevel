using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_非数值冒泡排序
{
    class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; set; }

        //构造方法-调用属性
        public Employee(string name,int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        //内部方法，前者的薪水高就true，反之亦然
        public static bool Compare(Employee e1,Employee e2)
        {
            if (e1.Salary > e2.Salary) return true;
            else return false;
        }


    }
}
