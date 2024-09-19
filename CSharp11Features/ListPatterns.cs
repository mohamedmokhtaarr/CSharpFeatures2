// ListPatterns.cs
namespace CSharp11Features;

public class ListPatterns
{
    public void MatchList(int[] numbers)
    {
        if (numbers is [1, 2, 3])
        {
            Console.WriteLine("Matched [1, 2, 3]");
        }
        else
        {
            Console.WriteLine("Did not match [1, 2, 3]");
        }
    }
}
//Feature: List patterns allow for pattern matching against lists or arrays,
//providing a concise way to work with collections.

