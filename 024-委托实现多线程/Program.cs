using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_委托实现多线程
{
    class Program
    {
        static string TestMultiThread(string str)
        {
            Console.WriteLine("TestMultiThread" + str);
            Thread.Sleep(100);//模拟这个线程时间比较长，暂停线程的单位是毫秒
            return "finished";
        }
        static void Main(string[] args)
        {
            //使用antion的异步编程，一般用于某个方法占用资源较久，会单独开一个线程给他用
            //Action<string> aMT = TestMultiThread;
            //aMT.BeginInvoke("tao",null, null);

            //有返回值的异步编程
            Func<string, string> f = TestMultiThread;
            IAsyncResult ar = f.BeginInvoke("taoBaobei", null, null);
            Console.WriteLine("Main");
            while(ar.IsCompleted == false)
            {
                Console.Write(".");
                Thread.Sleep(10);//我们这里10毫秒检测一下开的线程是不是结束了
            }
            string res = f.EndInvoke(ar);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
