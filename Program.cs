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
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko1"));
            university.AddStudent(new Student("Andrew Kostenko2"));
            university.AddStudent(new Student("Andrew Kostenko3"));
            university.AddStudent(new Student("Andrew Kostenko4"));
            university.AddStudent(new Student("Andrew Kostenko5"));


            Internship internship = new Internship("Interlink");
            internship.GetStudents(university);

        }
    }
}
