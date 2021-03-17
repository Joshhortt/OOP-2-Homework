// HOMEWORK - 11 - Mini-Project Student Details - Extension Methods

namespace StudentDetails
{
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
