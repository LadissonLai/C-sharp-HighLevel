using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_匿名方法
{
    class Program
    {
        //匿名方法求两个数的和
        Func<int, int, int> nononym = delegate (int arg1, int arg2)
          {
              return arg1 + arg2;
          };
        static void Main(string[] args)
        {
            
        }
    }
}
