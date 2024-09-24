// FileScopedNamespace.cs

//Feature: File - scoped namespaces allow you to declare a namespace for an entire file without the need for curly braces.

//Explanation: By using a semicolon after the namespace declaration, all the types in the file belong to this namespace,
//making the code cleaner and more readable.

using System.Reflection;

namespace CSharp10Features.FileScopedNamespace;

public class Person
{
    public string? Name { get; set; }
    public void Print()
    {
		string? namespaceName = MethodBase.GetCurrentMethod()?.DeclaringType?.Namespace;
		Console.WriteLine($"File-scoped namespaces in C# 10 is {namespaceName}");
    }
}
