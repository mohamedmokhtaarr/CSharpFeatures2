// ExtendedPropertyPatterns.cs

//Feature: Extended property patterns allow for more concise and readable pattern matching on nested properties.

//Explanation: This feature simplifies the code for checking nested properties,
//making it more readable and maintainable.

namespace CSharp10Features;

public class ExtendedPropertyPatterns
{
    public class Address
    {
        public string? Street { get; set; }
        public string? City { get; set; }
    }

    public class Person
    {
        public string? Name { get; set; }
        public Address? Address { get; set; }
    }

    public void MatchPerson(Person person)
    {
		//if (person is { Address: { City: "New York" } { Street : " 7Th Wolf St."} })
			if (person is { Address.City: "New York"  })
        {
            Console.WriteLine("The person lives in New York.");
        }
        else
        {
            Console.WriteLine("The person lives outside New York.");
        }
    }
}
