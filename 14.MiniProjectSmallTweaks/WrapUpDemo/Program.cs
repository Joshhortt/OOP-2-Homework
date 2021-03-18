// HOMEWORK - 14 - Mini-Project - 'Small Tweaks' about Generics and Events
// Recreate the project. Make sure you make small tweaks.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{ StudentId = 49, FirstName = "Josh", LastName = "Hortt: ", Email = "joshhortt@yahoo.comzz"},
                new Student{ StudentId = 21, FirstName = "Ana", LastName = "Horta: ", Email = "ana.horta@outlool.comxx"},
                new Student{ StudentId = 31, FirstName = "Sofia", LastName = "Nasala: ", Email = "sofia.nasala@hotmail.comyy"}
            };

            List<Lecture> lectures = new List<Lecture>
            {
                new Lecture{ LectureId = 1012, Course = "Introduction to Computer Science I: ", Unit = "Object Oriented Programmingww"},
                new Lecture{ LectureId = 0015, Course = "College Algebra: ", Unit = "zzRational Expressions" },
                new Lecture{ LectureId = 1073, Course = "C++ Programming: ", Unit = "Data Structuresww" },
            };

            DataAccess<Student> studentData = new DataAccess<Student>();
            studentData.ErrorFound += StudentData_ErrorFound;

            studentData.SaveToCSV(students, @"C:\Temp\SavedFiles\students.csv");

            DataAccess<Lecture> lectureData = new DataAccess<Lecture>();
            lectureData.ErrorFound += LectureExam_ErrorFound;

            lectureData.SaveToCSV(lectures, @"C:\Temp\SavedFiles\lecture.csv");

            Console.ReadLine();
        }

        private static void LectureExam_ErrorFound(object sender, Lecture e)
        {
            Console.WriteLine($"Error found in Course: { e.Course } { e.Unit }");
        }

        private static void StudentData_ErrorFound(object sender, Student e)
        {
            Console.WriteLine($"Error found in Student: { e.FirstName } { e.LastName } { e.Email}");
        }
    }
}
