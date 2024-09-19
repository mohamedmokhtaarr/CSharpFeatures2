// Utf8StringLiterals.cs
using System.Text;

namespace CSharp11Features;

public class Utf8StringLiterals
{
    public void ShowUtf8String()
    {
        ReadOnlySpan<byte> utf8String = "Hello, UTF-8"u8;
        Console.WriteLine(Encoding.UTF8.GetString(utf8String));
    }
}
//Feature: Allows strings to be stored more efficiently
//by using UTF-8 encoding directly in the source code.