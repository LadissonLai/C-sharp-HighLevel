using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_测试共有和私有
{
    class Program
    {
        static void Main(string[] args)
        {
            nameTest nameT = new nameTest();
            DeprivedClass dC = new DeprivedClass();
            Console.WriteLine(nameT.privateName);    // private关键字是，实例化的对象不能调用，只能在类内部调用
            Console.WriteLine(nameT.publicName);     // public关键字是，实例化的对象能直接调用
            Console.WriteLine(nameTest.staticName);  // static关键字只负责，能否直接使用类名调用类成员（字段，属性，方法），也必须添加public
            Console.WriteLine(nameT.staticName);     // static关键字， 不可以在实例化中调用
            Console.WriteLine(nameT.protectedName);  //保护字段是私有字段，只是在继承的时候有用
            Console.WriteLine(dC.protectedName);     //保护字段在继承后也是私有字段
            
            Console.ReadKey();
        }
    }
}
