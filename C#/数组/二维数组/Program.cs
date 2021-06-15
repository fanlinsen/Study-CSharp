using System;

namespace MyArray
{
    class muarray
    {
        static void Main(string[] args)
        {
            /*一个人五行二列的数组*/
            int[,] a = new int[5,2]{{0,1},{1,2},{3,4},{5,6},{7,8}};
            int i,j;
            /*输出数组中每个元素的值*/
            for(i = 0;i<5 ;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}",i,j,a[i,j]);
                }
            }
        }
    }
}
