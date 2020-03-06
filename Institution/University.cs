using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
  public class University
  {
    public string nameUniversity { get; }
    public List<Student> listStudents { get; private set; }

    public University(string name)
    {
      this.nameUniversity = name;
      this.listStudents = new List<Student>();
    }

    public int averageScore
    {
      get
      {
        int score = 0;
        foreach (Student student in listStudents)
        {
          score += student.levelKnowledge.level;
        }
        return score / listStudents.Count;
      }

    }

    public void enrolStudent(Student student)
    {
      listStudents.Add(student);
    }
  }
}