// 01 - Homework - Inheritance
// Implement a four classes: car, vehicle, bus and boat. Identify what inheritance should happen, if any, and wire it up.

// Note that a vehicle can be anything from a motorcycle to a car or bus even a boat.
// We all know that vehicles share too many specification and functionalities among them.
// So, how about having one class that can hold implements
// all these shared areas instead of repeating them in each different class?
// This is when inheritance gets involved and it's very helpful in Development.

//A base class is the class that act as a parent class of other classes. It’s a class that gives both it's data and behavior
//to derived class, such as the vehicle class giving its members to the Car class for example.
//The base class doesn’t inherit from any other class. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.SetMileage(10000);
			Console.WriteLine("Kms: " + myCar.GetKilometrage().ToString());
			Console.ReadKey();
		}
	}
}
