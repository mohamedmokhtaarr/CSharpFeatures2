// LambdaImprovements.cs

//Feature: C# 10 introduces improvements to lambda expressions, such as natural type for lambdas and the ability to use attributes and modifiers with lambdas.

//Explanation: These improvements enhance the flexibility and power of lambda expressions,
//making them more versatile and easier to use in a variety of scenarios.
namespace CSharp10Features;

public class LambdaImprovements
{
    public void DemonstrateLambdas()
    {
        Func<int, int, int> add = (a, b) => a + b;  

        Console.WriteLine($"Lambda adding 2 + 3 = {add(2, 3)}");


		//static int Sum(int x, int y)
		//{
		//	return x + y;
		//}

		//static void Test()
		//{
		//	Func<int, int, int> add = Sum;

		//	int result = add(10, 10);

		//	Console.WriteLine(result);
		//}


		//Func<string> helloWorld = () => "Hello World";
		//Console.WriteLine(helloWorld());
	}
}
