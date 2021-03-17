// 12 - HOMEWORK - Generics

// Create a generic class with a generic constructor, generic member variable, generic property, and a generic method,
//that takes in an item and calls ToString() method and prints that value to the console.

using System;

namespace GenericsHomework
{
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
