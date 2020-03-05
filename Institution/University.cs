using InternshipTest.Person;
using System.Collections.Generic;


namespace InternshipTest.Institution
{
    public class University
    {
        string nameUniversity;
        string nameStudent;
        
        public List<Student> listStudent = new List<Student>();

        public University(string name) {
            this.nameUniversity = name;
        }

        public string getNameUniversity() {
            return this.nameUniversity;
        }
        
        public string getNameStudent() {
            return this.nameStudent;
        }

        public List<Student> getListStudent() {
            return this.listStudent;
        }

        public void outStudents() {
            foreach(var student in listStudent) {
                System.Console.WriteLine($"{student.getNameStudent()} - {student.getLevelKnowledge()}");
            }
        }

        public void AddStudent(Student student) {
            this.nameStudent = student.getNameStudent();
            listStudent.Add(student);
        }
    }
}



// using InternshipTest.Person;
// using System.Collections.Generic;


// namespace InternshipTest.Institution
// {
//     public class University
//     {
//         string nameUniversity;
//         string nameStudent;
        
//         public List<Student> listStudent{get; }

//         public University(string name) {
//             this.nameUniversity = name;
//         }

//         public string getNameUniversity() {
//             return this.nameUniversity;
//         }
        
//         public string getNameStudent() {
//             return this.nameStudent;
//         }

//         // public List<Student> getListStudent() {
//         //     return this.listStudent;
//         // }

//         public void outStudents() {
//             foreach(var student in listStudent) {
//                 System.Console.WriteLine($"{student.getNameStudent()} - {student.getLevelKnowledge()}");
//             }
//         }

//         public void AddStudent(Student student) {
//             this.nameStudent = student.getNameStudent();
//             listStudent.Add(student);
//         }
//     }
// }
