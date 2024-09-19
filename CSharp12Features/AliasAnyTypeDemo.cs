using System;

namespace CSharp12Features
{
    using IntArray = int[];
    using Mokh = string;

    class AliasAnyTypeDemo
    {
        public void RunDemo()
        {
            Mokh mokh = "Mokhtar";
            IntArray numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Alias Any Type: " + string.Join(", ", numbers));
        }
    }
}
