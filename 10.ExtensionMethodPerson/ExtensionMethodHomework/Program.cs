// 10 - HOMEWORK - Extension Methods
// Create a chain using extension methods and Fluent Design pattern.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodHomework
{
	public class Program
	{
		static void Main(string[] args)
		{
			var person = Person.Create().WithName("Josh Hortt").OfSize(82, 182);  
			var person2 = Person.Create().WithName("Anna Cumea").OfSmallSize().WithAge();
            var person3 = Person.Create().WithName("Sofia Rebelo").OfMediumSize().WithAge();
            var person4 = Person.Create().WithName("Alex Machado").OfLargeSize().WithAge();

			Console.WriteLine("\nShowing Young People with the same age, but with different sizes:");

            Console.WriteLine(person);
			Console.WriteLine();

			Console.WriteLine(person2);
            Console.WriteLine();

            Console.WriteLine(person3);
            Console.WriteLine();

            Console.WriteLine(person4);

			Console.ReadLine();
        }
	}
}
