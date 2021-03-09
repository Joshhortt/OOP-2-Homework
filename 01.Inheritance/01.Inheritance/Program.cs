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
