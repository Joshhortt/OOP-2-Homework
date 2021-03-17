// 12 - HOMEWORK - Generics

// Create a generic class with a generic constructor, generic member variable, generic property, and a generic method,
//that takes in an item and calls ToString() method and prints that value to the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
	class Program
	{
		static void Main(string[] args)
		{
			GenericClass<int> integerGenericClass = new GenericClass<int>(11);
           // int val = integerGenericClass.GenericMethod(99);
            _ = integerGenericClass.GenericMethod(99); // use discard

			Console.WriteLine("");

			GenericClass<string> stringGenericClass = new GenericClass<string>("This is all Generics!")
			{
				GenericProperty = "This is a generic property."
			};
			// string result = stringGenericClass.GenericMethod("Generic Parameter");
			_ = stringGenericClass.GenericMethod("Generic Parameter");  // use discard

            Console.ReadLine();
		}
	}
}
