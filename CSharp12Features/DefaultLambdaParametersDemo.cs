using System;

namespace CSharp12Features
{
    class DefaultLambdaParametersDemo
    {
        public void RunDemo()
        {
            Console.WriteLine("Default Lambda Parameters: " + AddWithDefault(3)); // Outputs 8
        }

        private int AddWithDefault(int x, int y = 5)
        {
            return x + y;
        }
    }
}
