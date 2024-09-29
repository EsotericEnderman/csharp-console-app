#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
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
