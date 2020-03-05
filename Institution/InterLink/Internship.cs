using InternshipTest.Institution;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string internshipName { get; }
        public Internship(string name) {
            this.internshipName = name;
        }

        public void studentSelection(University university) {
            System.Console.WriteLine($"Список студентів зарахованих в {internshipName}");
            foreach(var student in university.listStudent){
                System.Console.WriteLine($"{student.studentName} - {student.levelKnowledge.level} - {university.nameUniversity}");
            }
        }

    }
}