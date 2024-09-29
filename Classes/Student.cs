namespace CSharpConsoleApp.Classes
{

    internal class Student(string name, string major, double gpa)
    {

        public string name = name;
        public string major = major;
        public double gpa = gpa;

        public bool HasHonours()
        {
            return gpa > 3.5D;
        }
    }
}
