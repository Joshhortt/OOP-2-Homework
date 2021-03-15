using System;

namespace MethodOverloadHomework
{
    partial class Program
    {
        public class NewEmployee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ID{ get; set; }
            public string Department { get; set; }
            public string Team { get; set; }

            public NewEmployee() : this("Josh", "Default lastName")
            {
                Console.WriteLine("Reserving a new record for the new employee.");
            }
            public NewEmployee(string firstName) : this(firstName, "Default lastName")
            {
                this.FirstName = firstName;
                Console.WriteLine("Creating a record for the new employee, with firstName!");
            }
            public NewEmployee(string firstName, string lastName) : this(firstName, lastName, "JH04", "Development Department", "The C# team")
            {
                this.LastName = lastName;
                this.FirstName = firstName;
                Console.WriteLine("Creating a record for the new employee, with firstName and lastName!");
            }
            public NewEmployee(string firstName, string lastName, string id, string department, string team)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.ID = id;
                this.Department = department;
                this.Team = team;
                Console.WriteLine("Creating a record for the new employee, with firstName, lastName, id, department & team!");
            }
        }
    }
}