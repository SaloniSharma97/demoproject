using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Mathematics

    {
        public double SuperRoot(double number)// non static method
        {
            double result;
            result = Math.Sqrt(number);
            return result;

        }
        public static double Power(short x, short y)//static method

        {
            double result;
            result = Math.Pow(x, y);
            return result;

        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            double result = m.SuperRoot(34);//in non static method we have to create obj for function calling
            Console.WriteLine(result);
            //-------------------------------
            result = Mathematics.Power(2, 4);// in static there is no need to create obj we directly call it by class name
            Console.WriteLine(result);
        }

    }
}
