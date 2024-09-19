// ConstantInterpolatedStrings.cs

//Feature: C# 10 allows you to define constant interpolated strings.
//قبل كدا مكنش ينفع تعمل interpolation مع const
//Explanation: Constant interpolated strings can now be defined using const,
//allowing compile-time evaluation of string interpolation.
namespace CSharp10Features;

public class ConstantInterpolatedStrings
{
    const string Greeting = "Hello";
    const string Subject = "World";
    const string Message = $"{Greeting}, {Subject}!";

    public void PrintMessage()
    {
        Console.WriteLine(Message);
    }
}
