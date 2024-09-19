using System;

namespace CSharp12Features
{
    class RefReadonlyParametersDemo
    {
        public static int number =5;
        public void RunDemo()
        {
            number++;
            //int number = 5;
            PrintNumber(in number);
        }

        static void PrintNumber(ref readonly int num)
        {
            Console.WriteLine("ref readonly Parameters: " + num);
        }
    }
}
