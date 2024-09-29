namespace CSharpConsoleApp.Classes
{
    internal class Student
    {
        public string name;
        public string major;

        public double GPA;

        public Student(string name_, string major_, double GPA_)
        {
            name = name_;
            major = major_;
            GPA = GPA_;
        }

        public bool HasHonours()
        {
            return GPA > 3.5;
        }
    }
}
