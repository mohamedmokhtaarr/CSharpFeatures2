using System;

namespace CSharp9Features
{
    public class TargetTypedConditional
    {
        public void Demo()
        {
            bool condition = false;
            Person person = condition ? new Person("John", "Doe", 1) : new Person("mohamed", "Doe", 1);
            Console.WriteLine(person.FirstName);
        }
    }
}
//Explanation:
//Target - typed conditional expressions allow the type of the conditional expression to be inferred from the target type,
//reducing redundancy and enhancing readability.