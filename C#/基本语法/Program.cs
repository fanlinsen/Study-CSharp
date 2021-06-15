using System;
namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        string aaa = @"hello";   
        //@（称作"逐字字符串"）将转义字符（\）当作普通字符对待例子：string str = @"C:\Windows";等价于string str = "C:\\Windows";
        public void Acceptdetails()
        {
            length = 4.5;
            width  = 3.5;
        }
        public double GetArea()         //计算面积
        {
            return length * width;
        }
        public  void Display()
        {
            Console.WriteLine("Length: {0} Width: {1}",length,width);
            //Console.WriteLine("Width: {0}",width);
            Console.WriteLine("Area: {0}",GetArea());
        }
        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.Acceptdetails();
                r.GetArea();
                r.Display();
            }
        }
    }

}