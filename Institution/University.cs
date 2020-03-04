using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        // List<string> listStudent = new List<string>();
        //не зберігати в масив
        Dictionary<string, int> list = new Dictionary<string, int>();
        string nameUniversity;

        public University(string name) {
            this.nameUniversity = name;
        }

        public string getNameUniversity() {
            return this.nameUniversity;
        }

        public void AddStudent(Student student, Knowledge knowledge) {
            this.list.Add(student.getNameStudent(), knowledge.getLevel());
        }

        public void outListStudent() {
            foreach (var val in list)
            {
                System.Console.WriteLine(val + " ");
            }
        }
    }
}
