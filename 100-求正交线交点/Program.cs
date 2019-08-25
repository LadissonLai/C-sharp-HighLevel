using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_求正交线交点
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo
            List<ZJXDataDefine> myLines = new List<ZJXDataDefine>()
            {
                new ZJXDataDefine(){LineID=1,Points = new List<PointDraw>(){new PointDraw(-1f, 4f), new PointDraw(3f,4f), new PointDraw(3f,1f), new PointDraw(5f, 1f)}},
                new ZJXDataDefine(){LineID=2,Points = new List<PointDraw>(){new PointDraw(1f, 5f), new PointDraw(1f,2f), new PointDraw(5f,2f), new PointDraw(5f, 0f)}},
                new ZJXDataDefine(){LineID=3,Points = new List<PointDraw>(){new PointDraw(4f,0f),new PointDraw(4f,5f)}}
            };
            foreach(var temp in myLines)
            {
                Console.WriteLine("this LineId = " + temp.LineID);
                foreach(var point in temp.Points)
                {
                    Console.Write("(" + point.X + "," + point.Y + ")" + "  ");
                }
                Console.WriteLine();
            }
            //计算三条线段的交点
            List<PointDraw> allCrossPoints = AllCrossPointsOfLinesArray(myLines);
            if (allCrossPoints != null)
            {
                Console.WriteLine("两条直线的交点是：");
                foreach (var crossPoint in allCrossPoints)
                {
                    Console.WriteLine("(" + crossPoint.X + "," + crossPoint.Y + ")");
                }
            }
            else
            {
                Console.WriteLine("两条直线没有交点");
            }
            Console.ReadKey();
        }

        //最简单的两条线段求交点
        static PointDraw CrossPointOfShort2Lines(ZJXDataDefine line1,ZJXDataDefine line2)
        {
            //只考虑一条直线仅两个端点
            PointDraw l1Point0 = line1.Points[0];
            PointDraw l1Point1 = line1.Points[1];
            PointDraw l2Point0 = line2.Points[0];
            PointDraw l2Point1 = line2.Points[1];

            //两条直线平行时
            if(((l1Point0.X - l1Point1.X) * (l2Point0.X - l2Point1.X) + (l1Point0.Y - l1Point1.Y) * (l2Point0.Y - l2Point1.Y)) != 0)
            {
                return null;
            }
            //两条直线垂直时
            if (l1Point0.X == l1Point1.X)
            {
                if(l1Point0.X >= Math.Min(l2Point0.X,l2Point1.X) && l1Point0.X <= Math.Max(l2Point0.X, l2Point1.X))
                {
                    if(l2Point0.Y == l2Point1.Y)
                    {
                        if(l2Point0.Y >= Math.Min(l1Point0.Y,l1Point1.Y) && l2Point0.Y <= Math.Max(l1Point0.Y, l1Point1.Y))
                        {
                            return new PointDraw(l1Point0.X, l2Point0.Y);
                        }
                        else
                        {
                            //Console.WriteLine("没有焦点");
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else if (l1Point0.Y == l1Point1.Y)
            {
                //交换线段1和线段2的位置，递归调用
                return CrossPointOfShort2Lines(line2, line1);
            }
            else
            {
                return null;
            }
        }
        //拆分多条线的组成的线段
        static List<ZJXDataDefine> SplitLine(ZJXDataDefine line)
        {
            List<ZJXDataDefine> sonLines = new List<ZJXDataDefine>();
            if (line.Points.Count < 2)
            {
                Console.WriteLine("SplitLine方法中，参数线段输入有误");
                return null;
            }
            else if (line.Points.Count == 2)
            {
                sonLines.Add(line);
                return sonLines;
            }
            else
            {
                for (int i = 0; i < line.Points.Count-1; i++) 
                {
                    sonLines.Add(new ZJXDataDefine() { LineID = line.LineID, Points = new List<PointDraw>(){ line.Points[i], line.Points[i + 1]} });
                }
                return sonLines;
            }
        }
        //复杂的两条线求交点
        static List<PointDraw> CrossPointsOf2Lines(ZJXDataDefine line1,ZJXDataDefine line2)
        {
            List<PointDraw> crossPoints = new List<PointDraw>();
            List<ZJXDataDefine> lines1 = SplitLine(line1);
            List<ZJXDataDefine> lines2 = SplitLine(line2);
            PointDraw crossPoint = new PointDraw();
            foreach(var sonLine1 in lines1)
            {
                foreach(var sonLine2 in lines2)
                {
                    crossPoint = CrossPointOfShort2Lines(sonLine1, sonLine2);
                    if(crossPoint != null)
                    {
                        crossPoints.Add(crossPoint);
                    }
                }
            }
            return crossPoints;
        }
        //传入一组线段求所有交点
        static List<PointDraw> AllCrossPointsOfLinesArray(List<ZJXDataDefine> zjcLines)
        {
            if (zjcLines.Count < 2)
            {
                Console.WriteLine("线段数量小于2");
                return null;
            }
            List<PointDraw> allCrossPoints = new List<PointDraw>();
            List<PointDraw> tempCrossPoints = new List<PointDraw>();
            for(int i = 0; i < zjcLines.Count - 1; i++)
            {
                for(int j = i+1; j < zjcLines.Count; j++)
                {
                    tempCrossPoints = CrossPointsOf2Lines(zjcLines[i], zjcLines[j]);
                    if (tempCrossPoints != null)
                    {
                        foreach (var tempCrossPoint in tempCrossPoints)
                        {
                            allCrossPoints.Add(tempCrossPoint);
                        }
                    }
                }
            }
            return allCrossPoints;
        }
    }
}
