using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x , ref int y)
        {
            int temp;
            temp = x;
            x=y;
            y= temp;
        }

    }
    class main1
    {
        static void Main(string[] args)
        {
            NumberManipulator a = new NumberManipulator();
            int aa=2,bb=3;
            a.swap(ref aa,ref bb);
            Console.WriteLine("aa = {0}  bb = {1}",aa,bb);
        }
    }
}

