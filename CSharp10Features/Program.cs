

using CSharp10Features.FileScopedNamespace;

namespace CSharp10Features
{
    class Program
    {
        static void Main()
        {
			
            // Global usings are declared in GlobalUsings.cs
			var names = new[] { "Salah", "Mabrouk", "Ali", "Mokhtar" };
			var serialized = JsonSerializer.Serialize(names);
			Console.WriteLine(serialized);
			
            
            // File-scoped namespace
			var fileScopedNamespace = new Person();
            fileScopedNamespace.Print();

            
            // Extended property patterns
            var person = new ExtendedPropertyPatterns.Person
            {
                Name = "John Doe",
                Address = new ExtendedPropertyPatterns.Address { City = "New York", Street = "123 Main St" }
            };
            var extendedPropertyPatterns = new ExtendedPropertyPatterns();
            extendedPropertyPatterns.MatchPerson(person);

           
            // Constant interpolated strings
            var constantInterpolatedStrings = new ConstantInterpolatedStrings();
            constantInterpolatedStrings.PrintMessage();

           
            // Lambda improvements
            var lambdaImprovements = new LambdaImprovements();
            lambdaImprovements.DemonstrateLambdas();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
