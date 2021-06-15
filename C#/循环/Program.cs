using System;

namespace typeconversion
{
    class StringConversion
    {
    static void Main(string[] args)
        {
            int[,,] a = new int[2, 2, 2] { {{ 1, 55 }, { 3,4}},{{ 5, 6 }, { 7,8}} };//定义一个2行2列2纵深的3维数组a
            foreach(int i in a)
            {
                Console .WriteLine (i);
            }
        }
    }
}