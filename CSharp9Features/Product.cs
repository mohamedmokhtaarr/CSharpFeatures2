namespace CSharp9Features
{
	//public record Product

	public class Product
	{
	
		public string? Name { get; init; }
		public decimal Price { get; init; }
	}
}

//Explanation:
//Init - only properties allow properties to be set during object initialization
//but remain immutable afterwards. This is useful for creating immutable objects while
//retaining the flexibility of object initialization syntax