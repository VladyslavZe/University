using InternshipTest.Person;
using System.Collections.Generic;


namespace InternshipTest.Institution
{
    public class University
    {
        public string nameUniversity { get; }
        public List<Student> listStudent = new List<Student>();

        public University(string name) {
            this.nameUniversity = name;
        }

        public List<Student> getListStudent() {
            return this.listStudent;
        }

        public void AddStudent(Student student) {
            listStudent.Add(student);
        }
    }
}