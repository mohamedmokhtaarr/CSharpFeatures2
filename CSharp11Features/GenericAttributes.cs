using System;

namespace CSharp11Features;

[AttributeUsage(AttributeTargets.Class)]
    public class ExampleAttribute : Attribute
{
         public string Value { get; }

          public ExampleAttribute(string value)
    {
        Value = value;
    }
}

[Example("This is a generic attribute")]
       public class GenericAttributes
{
             public void ShowAttribute()
      {
        var attributes = (ExampleAttribute[])GetType().GetCustomAttributes(typeof(ExampleAttribute), false);
        foreach (var attribute in attributes)
        {
            Console.WriteLine(attribute.Value);
        }
    }
}

//Feature: Allows attributes to be generic, enabling more flexible and reusable code.

