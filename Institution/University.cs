using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
  public class University
  {
    public string nameUniversity { get; }
    public List<Student> listStudent { get; private set; }

    public University(string name)
    {
      this.nameUniversity = name;
      this.listStudent = new List<Student>();
    }

    public int averageScore
    {
      get
      {
        int score = 0;
        foreach (var student in listStudent)
        {
          score += student.levelKnowledge.level;
        }
        return score / listStudent.Count;
      }

    }

    public void enrolStudent(Student student)
    {
      listStudent.Add(student);
    }
  }
}