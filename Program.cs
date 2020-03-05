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
            University university1 = new University("CH.U.I.");
            university1.AddStudent(new Student("Andrew Kostenko1"));
            university1.AddStudent(new Student("Andrew Kostenko2"));
            university1.AddStudent(new Student("Andrew Kostenko3"));
            university1.AddStudent(new Student("Andrew Kostenko4"));
            university1.AddStudent(new Student("Andrew Kostenko5"));
            University university2 = new University("CH.B.K.");
            university2.AddStudent(new Student("Andrew Kostenko1"));
            university2.AddStudent(new Student("Andrew Kostenko2"));
            university2.AddStudent(new Student("Andrew Kostenko3"));
            university2.AddStudent(new Student("Andrew Kostenko4"));
            university2.AddStudent(new Student("Andrew Kostenko5"));
            University university3 = new University("V.U.I.");
            university3.AddStudent(new Student("Andrew Kostenko1"));
            university3.AddStudent(new Student("Andrew Kostenko2"));
            university3.AddStudent(new Student("Andrew Kostenko3"));
            university3.AddStudent(new Student("Andrew Kostenko4"));
            university3.AddStudent(new Student("Andrew Kostenko5"));


            Internship internship = new Internship("Interlink");
            internship.studentSelection(university1);
            internship.studentSelection(university2);
            internship.studentSelection(university3);

        }
    }
}
