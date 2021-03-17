// HOMEWORK - 11 - Mini-Project Student Details - Extension Methods
using System;

namespace StudentDetails
{
	public class Mentor
	{
		public DateTime BirthDate { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string GetName() => $"{LastName} {FirstName}";
	}

}
