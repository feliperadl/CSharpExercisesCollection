using System;

namespace Exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			// Student information
			string StudentFirstName;
			string StudentLastName;
			DateTime StudentBirthdate;
			string StudentAddressLine1;
			string StudentAddressLine2;
			string StudentCity;
			string StudentState_Province;
			string StudentZip_Postal;
			string StudentCountry;
			// Professor information
			string ProfessorFirstName;
			string ProfessorCourse;
			// university degree
			string universityDegree;
			// university program
			string ProgramName;
			string DepartmentHead;

			// Student information
			Console.WriteLine("Student information:");
			Console.WriteLine("First Name: ");
			StudentFirstName = Console.ReadLine();
			Console.WriteLine("Last Name: ");
			StudentLastName = Console.ReadLine();
			Console.WriteLine("Birthdate: ");
			StudentBirthdate = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Address Line 1: ");
			StudentAddressLine1 = Console.ReadLine();
			Console.WriteLine("Address Line 2: ");
			StudentAddressLine2 = Console.ReadLine();

			Console.WriteLine("City: ");
			StudentCity = Console.ReadLine();
			Console.WriteLine("State/Province: ");
			StudentState_Province = Console.ReadLine();
			Console.WriteLine("Zip/Postal: ");
			StudentZip_Postal = Console.ReadLine();
			Console.WriteLine("Country: ");
			StudentCountry = Console.ReadLine();
			Console.WriteLine(@"First Name: {0}, 
			Last Name: {1},
			Birthdate: {2},
			Address Line 1: {3}, Address Line 2: {4},
			City: {5}, 
			State/Province: {6}, 
			Zip/Postal: {7}, 
			Country: {8}", 
			StudentFirstName,
			StudentLastName,
			StudentBirthdate,
			StudentAddressLine1,
			StudentAddressLine2, 
			StudentCity,
			StudentState_Province,
			StudentZip_Postal,
			StudentCountry);
			// Professor information
			Console.WriteLine("Professor information:");
			Console.WriteLine("First Name: ");
			ProfessorFirstName = Console.ReadLine();
			Console.WriteLine("Course: ");
			ProfessorCourse = Console.ReadLine();

			Console.WriteLine("First Name: {0}, Course:{1}", ProfessorFirstName, ProfessorCourse);
			// university degree
			Console.WriteLine("university degree:");
			universityDegree = Console.ReadLine();

			Console.WriteLine("university degree: {0}", universityDegree);
			// university program
			Console.WriteLine("university program:");
			Console.WriteLine("Program Name:");
			ProgramName = Console.ReadLine();
			Console.WriteLine("Department Head:");
			DepartmentHead = Console.ReadLine();
			Console.WriteLine("Program Name: {0}, Department Head:{1}", ProgramName, DepartmentHead);
			Console.ReadKey();
		}
	}
}