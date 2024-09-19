// RawStringLiterals.cs
namespace CSharp11Features;

public class RawStringLiterals
{
    public void ShowRawString()
    {
        string rawString = """
        This is a "raw" string literal.
        It supports "multiple lines" and special characters like \ and .
      
        """;
        Console.WriteLine(rawString);
    }
}
//Feature: Raw string literals allow you to write strings without needing to escape special characters,
//and you can specify indentation and multiline strings more easily.