using InternshipTest.Institution;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string internshipName;
        public Internship(string name) {
            this.internshipName = name;
        }

        public void GetStudents(University university) {
            System.Console.WriteLine($"Список студентов {internshipName}");
            foreach(var student in university.getListStudent()){
                if(student.getLevelKnowledge() >= 5) {
                    System.Console.WriteLine($"{student.getNameStudent()} - {student.getLevelKnowledge()}");
                }
            }
        }

    }
}
