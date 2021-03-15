using System;

namespace ManagerData
{
	class Manager : Employee
    {
        double Bonus, Salary;
        public override void GetEmpData()
        {
            Console.WriteLine("Please enter Your Employee Details");

            Console.WriteLine("ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("NAME: ");
            Name = Console.ReadLine();
            Console.WriteLine("BONUS: ");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("SALARY: ");
            Salary = double.Parse(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("The Manager's id is: " + Id);
            Console.WriteLine("The Manager's name is: " + Name);
            Console.WriteLine("The Manager's bonus is: " + Bonus);
            Console.WriteLine("The Manager's salary is: " + Salary);
        }
    }
}

