using InternshipTest.Institution;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
  public class Internship
  {
    public string internshipName { get; }
    public List<Student> listStudents { get; private set; }
    public Internship(string name)
    {
      this.internshipName = name;
      this.listStudents = new List<Student>();
    }

    public void studentSelection(University university)
    {
      foreach (var student in university.listStudents)
      {
        if (student.levelKnowledge.level > university.averageScore)
        {
          listStudents.Add(student);
        }
      }
    }
  }
}