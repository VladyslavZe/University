using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        string nameUniversity;
        string nameStudent;
        int levelKnowledgeStudent;

        public University(string name) {
            this.nameUniversity = name;
        }

        public string getNameUniversity() {
            return this.nameUniversity;
        }
        
        public string getNameStudent() {
            return this.nameStudent;
        }

        public int levelKnowledge() {
            return this.levelKnowledgeStudent;
        }

        public void AddStudent(Student student) {
            this.nameStudent = student.getNameStudent();
            this.levelKnowledgeStudent = student.getLevelKnowledge();
            // System.Console.WriteLine($"Name student: {student.getNameStudent()}");
            // System.Console.WriteLine($"Level knowledge: {student.getLevelKnowledge()}");
        }
    }
}
