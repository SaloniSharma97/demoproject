using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Program obj = new Program();
            Console.WriteLine("Enter year:");
            year = Convert.ToInt32( Console.ReadLine());
            
            bool isLeap = obj.Leap(year);

            if(isLeap==true)
            Console.WriteLine("{0} is a leap year",year);
            else
            Console.WriteLine("{0} is not a leap year", year);
        }

        public bool Leap(int year)
        {
            if (year % 4 == 0)

            {
                if ((year % 400 == 0) || (year % 100 != 0))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}

