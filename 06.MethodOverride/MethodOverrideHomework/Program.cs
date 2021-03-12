// 06 - HOMEWORK - Method Overriding
// Create a Person class and override the ToString method in it. Make it return the user personal details.
// First name, Last name, etc...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideHomework
{
	class Program
        {
            static void Main(string[] args)
            {
                Person control = new Person() {Id = 99, FirstName = "Josh", LastName = "Hortt" };

                Console.WriteLine(control.ToString());
                Console.ReadLine();
            }
        }
    }
