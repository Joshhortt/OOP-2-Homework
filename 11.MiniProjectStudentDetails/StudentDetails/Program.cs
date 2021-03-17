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

	public class Mentor
	{
		public DateTime BirthDate { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string GetName() => $"{LastName} {FirstName}";
	}

	public class Student : Mentor
	{
		public int StudentIdNumber { get; set; }
	}

	public static class Extensions
	{
		public static string GetNameWithBirthDate(this Mentor person)
		{
			return $"{person.BirthDate.ToString("yyy-MM-dd")} - {person.GetName()}";
		}

		public static string GetStudentInfo(this Student student)
		{
			return $"{student.GetName()} - ID: {student.StudentIdNumber}";
		}

		public static string GetInitials(this Student student)
		=> $"Student: {student.LastName.ToCharArray()[0]}.{student.FirstName.ToCharArray()[0]}.";

		public static string GetInitials(this Mentor person)
			=> $"Mentor: {person.LastName.ToCharArray()[0]}.{person.FirstName.ToCharArray()[0]}.";
	}

}
