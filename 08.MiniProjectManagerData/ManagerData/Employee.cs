
using System;

namespace ManagerData
{
	 abstract class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    
		public abstract void GetEmpData();

        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Id is: " + this.Id);
            Console.WriteLine("Employee Name is: " + this.Name);
            Console.WriteLine("Employee Address is: " + Address);
            Console.WriteLine("Employee Age is: " + this.Age);
        }
		public Employee()
		{
			Console.WriteLine("Manager");
		}
	}
}

