using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
	public class Car : Vehicle
    {
        public double GetKilometrage()
        {
            return _mileage / 0.62137; // comes from the base class 
        }
    }
}
