// RequiredMembers.cs
namespace CSharp11Features;

public class RequiredMembers
{
    public class Person
    {
        public required string FirstName { get; init; } // init : To Initialize Without The Constructor
        public required string LastName { get; init; }
    }
    public void ShowPerson()
    {
        var person = new Person { FirstName = "John", LastName = "Doe" };
        Console.WriteLine($"{person.FirstName} {person.LastName}");
    }
}
//Feature: Introduces the required keyword to enforce that certain properties
//must be initialized during object construction.

