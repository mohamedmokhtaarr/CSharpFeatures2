using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;

namespace CSharp9Features
{
    public record Person(string FirstName, string LastName, int Id);

   // Explanation:
//Records provide a concise way to define immutable reference types with value-based equality.
//They are useful for data-centric applications, reducing boilerplate code for creating classes with property definitions,
//constructors, and equality members.
    public class WithExpressionDemo
    {
        public void Demo()
        {
            var person = new Person("John", "Doe" , 1);
            var modifiedPerson = person with { LastName = "Smith" , Id = 5};
            Console.WriteLine(modifiedPerson.LastName);
        }
    }
}

//Explanation:
//With expressions create a copy of an object with modifications to some properties.
//This is particularly useful with records, enabling a non-destructive
//mutation of immutable types.