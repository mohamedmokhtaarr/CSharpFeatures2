using System;
using System.Collections.Generic;

namespace CSharp12Features
{
    class CollectionExpressionsDemo
    {
        public void RunDemo()
        {
            List<int> numbers = [1, 2, 3, 4, 5];
            int[] array1 = [1, 2, 3];
            int[] array2 = [4, 5, 6];
            int[] array3 = [7, 8, 9];
			int[] combinedArray = [.. array1, .. array2,..array3];
            Console.WriteLine(combinedArray);
           Console.WriteLine("Collection Expressions: " + string.Join(", ", combinedArray));
        }
    }
}
