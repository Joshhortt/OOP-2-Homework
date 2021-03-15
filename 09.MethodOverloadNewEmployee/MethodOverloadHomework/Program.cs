// 09 - HOMEWORK - Method Overloading
// Create a Employee model class and create three different constructors, that take in different amounts of data.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadHomework
{
	partial class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("********** First Constructor! **********");
            NewEmployee first = new NewEmployee();
            Console.WriteLine(first.FirstName);

            Console.WriteLine("");

            Console.WriteLine("********** Second Constructor! **********");
            NewEmployee second = new NewEmployee();
            Console.WriteLine(second.Department);

            Console.WriteLine("");

            Console.WriteLine("********** Third Constructor! **********");
            NewEmployee third = new NewEmployee();
            Console.WriteLine(third.Team);

            Console.ReadLine(); ;
        }
    }
}