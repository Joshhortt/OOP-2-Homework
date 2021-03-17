// 12 - HOMEWORK - Generics
// Create a generic method that takes in an item and calls ToString() method and prints that value to the console.
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
    // GenericClass is a Generic Class
    public class GenericClass<T>
    {
        //Generic variable. The data type is generic
        private T GenericMemberVariable;

        //Generic Constructor. Constructor accepts one parameter of Generic type
        public GenericClass(T value)
        {
            GenericMemberVariable = value;
        }
        //Generic Method. Method accepts one Generic type Parameter. Method return type also Generic
        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), GenericMemberVariable);
            return GenericMemberVariable;
        }
        //GenericProperty is a generic property
        public T GenericProperty { get; set; }
    }
}
