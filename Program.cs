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
      University university3 = new University("V.U.I.");
      university3.enrolStudent(new Student("Andrew Kostenko1"));
      university3.enrolStudent(new Student("Andrew Kostenko2"));
      university3.enrolStudent(new Student("Andrew Kostenko3"));
      university3.enrolStudent(new Student("Andrew Kostenko4"));
      university3.enrolStudent(new Student("Andrew Kostenko5"));

      Internship internship = new Internship("Interlink");
      internship.studentSelection(university3);
      Console.WriteLine($"Средний бал: {university3.averageScore}");
      foreach (var student in internship.listStudent)
      {
        Console.WriteLine($"{student.studentName} - {student.levelKnowledge.level}");
      }

    }
  }
}