// NameofScope.cs
namespace CSharp11Features;
//Feature: Expands the scope where nameof can be used, including parameter defaults.

public class NameofScope
{
    //[Name (nameof(param))]
    public void ShowNameof(string param = nameof(ShowNameof))
    {
        Console.WriteLine(param);
    }
}

//public class NameAttribute : Attribute
//{
//	public string Value { get; }

//	public NameAttribute(string value)
//	{
//		Value = value;
//	}
//}

