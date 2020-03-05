using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        public string nameUniversity { get; }
        public List<Student> listStudent { get; private set; }

        public University(string name) {
            this.nameUniversity = name;
            this.listStudent = new List<Student>();
        }

        public void AddStudent(Student student) {
            listStudent.Add(student);
        }
    }
}