using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_测试共有和私有
{
    class DeprivedClass:nameTest
    {
        public string dName = "dName";
        public DeprivedClass()
        {
            this.protectedName = "dprotectedName";
        }
    }
}
