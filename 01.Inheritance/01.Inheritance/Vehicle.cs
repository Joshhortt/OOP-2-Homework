using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Vehicle
    {
        public Vehicle()
        { }
        protected string _type;
        protected string _engineType;
        protected double _mileage;
        protected void SetType(string type)
        {
            // such as car, bus, motorcycle.  
            _type = type;
        }
        protected void SetEngineType(string engineType)
        {
            // such as diesel, regular gas, unleaded gas 
            _engineType = engineType;
        }
        public void SetMileage(int mileage)
        {
            _mileage = mileage;
        }
    }
}
