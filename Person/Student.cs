namespace InternshipTest.Person
{
    public class Student
    {
        string studentName;
        // Knowledge knowledge;
        // public Student(string name, Knowledge knowledge)
        public Student(string name)
        {
            this.studentName = name;
            // SetKnowledge(knowledge);
        }

        public string getNameStudent() {
            return this.studentName;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            //TODO: Implementation is needed
            // this.knowledge = knowledge;
        }
    }
}