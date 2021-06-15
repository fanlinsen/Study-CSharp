using System;

namespace ArrayApplication
{
    class MyArray
    {
        private double getgetAverage(int[] arr ,int size)
        {
            int i;
            double avg;
            int sum = 0;

            for(i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }
        static void Main(string[] args)
        {
            MyArray a = new MyArray();
            /*一个带有五个元素的int数组*/
            int [] balance = new int[]{1000,2,3,17,50};
            double avg;

            /*传递数组的指针作为参数*/
            avg = a.getgetAverage(balance,5);

            /*输出返回值*/
            Console.WriteLine("平均值为： {0}",avg);
        }
    }
}
