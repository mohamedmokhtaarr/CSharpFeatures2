
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.Text.Json;

namespace CSharp10Features
{

    //              Global Usings
    //Feature: Global using directives allow you to specify using directives that apply to all the files in your project.
    //This helps reduce redundancy and clutter in your code files.

    //Explanation: These using directives are applied globally,
    //so you don't need to include them in every file within the project.
    public class GlobalUsings
    {
		public void Serialize()
        {
			var names = new[] { "Salah", "Mabrouk", "Ali", "Mokhtar" };
			var serialized = JsonSerializer.Serialize(names);
            Console.WriteLine(serialized);
        }
        

	}

}
