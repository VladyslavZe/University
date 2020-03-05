using System;

namespace InternshipTest.Person
{
    public class Student
    {
        public string studentName { get; }
        public Knowledge levelKnowledge { get; private set; }

        public Student(string name) {
            this.studentName = name;
            this.levelKnowledge = new Knowledge(randLevelStudent());
        }

        public int randLevelStudent() {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }
    }
}