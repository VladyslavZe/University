using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");

            university.AddStudent(new Student("Andrew Kostenko"), new Knowledge(34));
            university.AddStudent(new Student("Julia Veselkina"), new Knowledge(52));
            university.AddStudent(new Student("Maria Perechrest"), new Knowledge(78));

            // Internship internship = new Internship("Interlink");
            // Console.WriteLine("List of internship's students:");

            // Console.WriteLine(internship.GetStudents());
            // Console.WriteLine(university.getListStudent());
            university.outListStudent();
        }
    }
}
