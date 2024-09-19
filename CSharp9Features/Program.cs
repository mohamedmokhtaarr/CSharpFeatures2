namespace CSharp9Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var product1 = new Product() { Name = "Book", Price = 10 };
			var product2 = new Product() { Name = "Book", Price = 10 };
			Console.WriteLine(product1 == product2);

			//WithExpressionDemo expressionDemo = new WithExpressionDemo();
			//expressionDemo.Demo();

			//TargetTypedConditional targetTypedConditional = new TargetTypedConditional();
			//targetTypedConditional.Demo();

		}
	}
}
