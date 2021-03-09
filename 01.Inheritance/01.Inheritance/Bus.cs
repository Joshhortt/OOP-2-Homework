using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Bus : Vehicle
    {
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                Capacity = value;
            }
        }

        public double GetMileage()
        {
            return _mileage; // comes from the base class 
        }

        public int GetCapacity()
        {
            return Capacity; // specific to a bus 
        }
    }
}
