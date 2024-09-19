// NewlinesInStringInterpolations.cs
namespace CSharp11Features;

public class NewlinesInStringInterpolations
{
    public void ShowNewlinesInInterpolation()
    {
        string name = "World";
        Console.WriteLine($@"Hello, {name}!
        This is a multiline interpolated verbatim string.");
    }
}
