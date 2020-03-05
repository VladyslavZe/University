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
            int middleRating = 5;
            System.Console.WriteLine($"Список студентів зарахованих в {internshipName}");
            foreach(var student in university.getListStudent()){
                if(student.levelKnowledge.level >= middleRating) {
                    System.Console.WriteLine($"{student.studentName} - {student.levelKnowledge.level} - {university.nameUniversity}");
                }
            }
        }

    }
}
