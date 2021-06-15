using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int [] n = new int[10];
            int i,j;

            for(i=0;i<10;i++)
            {
                n[i] = i+100;
            }
            for(j=0;j<10;j++)
            {
                Console.WriteLine("第{0}数组是：{1}",j+1,n[j]);
            }
        }
    }
}
