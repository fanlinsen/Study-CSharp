/*交错数组是数组的数组。
交错数组是一维数组。*/
using System;
namespace ArrayApplication
{
    class MYarrray
    {
        static void Main(string[] strs)
        {
            int[][] a = new int[][]{new int[]{0,0,1,1},new int[]{1,2,1,1},new int[]{2,4,88,88},new int[]{3,6,1,1},new int[]{4,8,1,1}};
            int i,j;
            /*输出数组中每个元素的值*/
            for(i=0;i<5;i++)
            {
                for(j=0;j<4;j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}",i,j,a[i][j]);
                }
            }
        }
    }
}
