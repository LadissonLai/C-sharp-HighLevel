using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_委托
{
    class Program
    {
        private delegate string GetAString();
        static void Main(string[] args)
        {
            int a = 225;
            GetAString func = new GetAString(a.ToString);
            Console.WriteLine(func());
            Console.ReadKey();
        }
    }
}
