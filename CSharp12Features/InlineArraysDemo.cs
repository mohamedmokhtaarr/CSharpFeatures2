using System;

namespace CSharp12Features;
//Inline arrays allow you to declare and initialize arrays directly within the code.
//This feature provides a more concise syntax for creating arrays,
//improving readability and reducing the boilerplate code needed for array initialization.


unsafe struct MyStruct
    {
        public fixed int _data[5];
    }

    class InlineArraysDemo
    {
        public unsafe void RunDemo()
        {
            MyStruct myStruct = new MyStruct();
            for (int i = 0; i < 5; i++)
            {
                myStruct._data[i] = i * 10;
            }

            Console.WriteLine("Inline Arrays example:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myStruct._data[i]);
            }
        }
    }

public class InlineArrays
{
	public void DisplayInlineArray()
	{
		int [] numbers = [1, 2, 3, 4, 5];
		foreach (var number in numbers)
		{
			Console.WriteLine(number);
		}
	}
}