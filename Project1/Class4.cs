using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    //1.) call by ref 2)output parameters
    class Example
    {
        public static void CallByVal(int x)
        {

          x = 1000;
        }  
        public static void CallByRef(ref int x)
        {

        x = 12000;

        }
        public static void Main()

        {
        int x = 20;
//Example.CallByVal(x);
           Example.CallByRef(ref x);
            Console.WriteLine(x);
        }
        

    }
}
