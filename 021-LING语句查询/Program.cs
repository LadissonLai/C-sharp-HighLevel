using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_LING语句查询
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new List<KungfuMaster>()
            {
                new KungfuMaster(){Id=0, Name="黄蓉", Menpai="丐帮", Level=7},
                new KungfuMaster(){Id=1, Name="郭靖", Menpai="梅花岛", Level=10},
                new KungfuMaster(){Id=2, Name="令狐冲", Menpai="雪山派", Level=4}
            };

            //使用LINQ语句查询等级大于5的功夫大师
            var res = from m in masterList
                      where m.Level > 5
                      select m.Name;
            foreach(var temp in res)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
            //masterList.SelectMany()?
        }
    }
}
