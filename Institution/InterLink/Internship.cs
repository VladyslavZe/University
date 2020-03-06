using InternshipTest.Institution;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
  public class Internship
  {
    public string internshipName { get; }
    public List<Student> listStudent { get; private set; }
    public Internship(string name)
    {
      this.internshipName = name;
      this.listStudent = new List<Student>();
    }

    public void studentSelection(University university)
    {
      foreach (var student in university.listStudent)
      {
        if (student.levelKnowledge.level > university.averageScore)
        {
          listStudent.Add(student);
        }
      }
    }
  }
}