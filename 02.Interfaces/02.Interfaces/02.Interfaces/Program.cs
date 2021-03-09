// 02 - HOMEWORK - Interfaces
// Create an IRun Interface and apply it to a Person class and Animal class.
// Store both types in a List<IRun> object

//Interfaces are objects in C# that looks as same as a class, but with no implementations.
//In other words, the interface contains a declaration or signature of methods, events, properties, or indexer.
//Declaration without implementation?
//Every declaration in an interface will have its associated implementations in a separate class.   

//The beauty of the interface is that it allows the developer to put the declaration only in one place
//which will make it easier to architect and understand what the implementing class contains.
//The class implementing the interface should contain the exact members in the interface or it will throw an error.
//A good point to remember that interface member can only be public, and there are public by default.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interfaces
{
	class Program
    {
        static void Main(string[] args)
        {
            List<IRun> organism = new List<IRun>();

            Person dadHuman = new Person();
            Person momHuman = new Person();
            Person sibHuman = new Person();

            Animal canguruAnimal = new Animal();
            Animal monkeyAnimal = new Animal();
            Animal chickenAnimal = new Animal();

            organism.Add(dadHuman);
            organism.Add(momHuman);
            organism.Add(sibHuman);

            organism.Add(canguruAnimal);
            organism.Add(monkeyAnimal);
            organism.Add(chickenAnimal);

            foreach (IRun livingBeing in organism)
            {
               //livingbeing - only uses what the IRun interface has in its contract
                livingBeing.Run();
            }
            Console.ReadLine();
        }
    }
}
