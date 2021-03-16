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
    public class Person
    {
		public string Name { get; set; }
		public int Weigth { get; set; }
		public int Height { get; set; }
		public int HasAge { get; set; }

	
        private Person()
        {
        }

        public static Person Create()
        {
            return new Person() { Name = "My Person", Weigth = 75, Height = 170, HasAge = 18 };
            
        }

        public Person WithName(string name)
        {
            Name = name;
            return this;
        }

        public Person OfSize(int weigth, int height)
        {
            Weigth = weigth;
            Height = height;
            return this;
        }

        public Person WithAge()
        {
            HasAge = 18;
            return this;
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nWeigth: {1}\nHeight: {2}\nAge: {3}", Name, Weigth, Height, HasAge);
        }
    }

    public static class MorePersons
    {
        public static Person OfSmallSize(this Person person)
        {
            person.Weigth = 50;
            person.Height = 150;
            person.HasAge = 18;
            return person;
        }

        public static Person OfMediumSize(this Person person)
        {
            person.Weigth = 75;
            person.Height = 170;
            person.HasAge = 18;
            return person;
        }

        public static Person OfLargeSize(this Person person)
        {
            person.Weigth = 100;
            person.Height = 190;
            person.HasAge = 18;
            return person;
        }

        public static Person OfSize(this Person person, int weigth, int height, int hasAge)
        {
            person.Weigth = weigth;
            person.Height = height;
            person.HasAge = hasAge;

            return person;
        }
    }
}
