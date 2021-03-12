// 04 - HOMEWORK - Access Modifiers
// Create a Console Application and a Class Library, then create a public class with members that have different Modifiers.
// Add some Tweaks. Try each out.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMLibrary;

namespace AccessModifiersHomework

{
    class Program
    {
        static void Main(string[] args)
        {
            AccessAM accessModifier = new AccessAM();

            //accessModifier.

            CreditCard limitAge = new CreditCard();

            limitAge.Age = 99;
            limitAge._age = 99;

            accessModifier.PublicAM();
        }

        private static void Greeting()
        {
            Console.WriteLine("Welcome!");
        }
    }
}
