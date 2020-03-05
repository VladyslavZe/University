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
            if (university.levelKnowledge() >= 5) {
                System.Console.WriteLine($"Проходит на интернатуру {internshipName}: {university.getNameStudent()}");
                System.Console.WriteLine($"Уровень знаний: {university.levelKnowledge()}");
                System.Console.WriteLine($"Университет: {university.getNameUniversity()}");
            } else {
                System.Console.WriteLine($"{university.getNameStudent()} - уровень знаний низкий. Нужно еще подучиться...");
                System.Console.WriteLine($"Уровень знаний: {university.levelKnowledge()}");
                System.Console.WriteLine($"Университет: {university.getNameUniversity()}");
            }
        }
    }
}
