// HOMEWORK - 11 - Mini-Project Student Details - Extension Methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
	class Program
	{
		static void Main(string[] args)
		{

			var mentor = new Mentor()
			{
				FirstName = "Josh",
				LastName = "Hortt",
				BirthDate = new DateTime(1982, 2, 23)
			};
			Console.WriteLine("Mentor Details: ");
			Console.WriteLine(mentor.GetName());
			Console.WriteLine(mentor.GetInitials());

			Console.WriteLine("");

			var student = new Student()
			{
				FirstName = "Carla",
				LastName = "Ferreira",
				BirthDate = new DateTime(1996, 8, 3),
				StudentIdNumber = 320
			};
			Console.WriteLine("Student Details: ");
			Console.WriteLine(student.GetNameWithBirthDate());
			Console.WriteLine(student.GetStudentInfo());
			Console.WriteLine(student.GetInitials());

			Console.ReadLine();
		}
	}
}
