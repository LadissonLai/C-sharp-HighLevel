using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_LING语句查询
{
    class KungfuMaster
    {
        public int Id;
        public string Name;
        public string Menpai;
        public int Level;

        public override string ToString()
        {
            return string.Format("Id:{0},Name:{1},Menpai:{2},Level:{3}", Id, Name, Menpai, Level);
        }
    }
}
