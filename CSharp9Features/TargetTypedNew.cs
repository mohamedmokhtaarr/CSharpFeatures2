using System.Linq.Expressions;
using System;

namespace CSharp9Features
{
    public class TargetTypedNew
    {
        public void CreateObjects()
        {
            Person person1 = new Person(FirstName : "Mohamed" , LastName : "Mokhtar" +
                "", Id: 3) ;
            Person person = new("John", "Doe", 1);
        }
    }
}
//Explanation:
//Target - typed new expressions allow omitting the type on the right-hand side of a new
//expression when the type can be inferred from the context. This reduces redundancy and improves code readability.