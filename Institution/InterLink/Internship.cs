namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string internshipName;
        public Internship(string name)
        {
            this.internshipName = name;      
        }

        //логіка по відбору студентів
        public string GetStudents()
        {
            return "Andrew Maslenko\nJulia Veselkina\n";
        }
    }
}
