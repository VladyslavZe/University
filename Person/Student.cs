using System;
namespace InternshipTest.Person
{
    public class Student
    {
        string studentName;
        Knowledge levelKnowledge;

        public Student(string name) {
            this.studentName = name;
            SetKnowledge(new Knowledge(randLevelStudent()));
        }

        public int randLevelStudent() {
            Random rnd = new Random();
            return rnd.Next(2, 10);
        }

        public string getNameStudent() {
            return this.studentName;
        }

        public int getLevelKnowledge() {
            return this.levelKnowledge.getLevel();
        }

        public void SetKnowledge(Knowledge knowledge) {
            this.levelKnowledge = knowledge;
            // Console.WriteLine(knowledge.getLevel());
        }
    }
}