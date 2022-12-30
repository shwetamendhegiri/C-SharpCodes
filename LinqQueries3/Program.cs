using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries3
{
	public class Student
	{
		public int RollNo { get; set; }
		public string StudentName { get; set; }
		public int Marks { get; set; }
	}


	public class Program
	{

		public static void Main()
		{
			var students = new List<Student>()
			{
				new Student() {RollNo =1, StudentName ="Shweta", Marks =80},
				new Student() {RollNo =2, StudentName ="Meera", Marks =92},
				new Student() {RollNo =3, StudentName ="Dipika", Marks =85},
				new Student() {RollNo =4, StudentName ="Radha", Marks =76}
			};

			foreach (var stud in students)
			{
				Console.WriteLine(stud.RollNo + " " + stud.StudentName + " " + stud.Marks);
			}
			Console.WriteLine();

			var studentQuery =
				from student in students
				where student.StudentName == "Meera"
				select student;

			foreach (var student in studentQuery)
			{
				Console.WriteLine(student.RollNo + " " + student.StudentName);

			}
			Console.WriteLine();
			var studentQuery1 =
				from student in students
				where student.StudentName.StartsWith("S")
				select student;

			foreach (var student in studentQuery1)
			{
				Console.WriteLine(student.RollNo + " " + student.StudentName);
			}
			Console.WriteLine();

			var studentQuery2 =
				from student in students
				where student.Marks > 80
				select student;

			foreach (var student in studentQuery2)
			{
				Console.WriteLine(student.RollNo + " " + student.StudentName + " " + student.Marks);
			}

			Console.ReadLine();
		}
	}

}
