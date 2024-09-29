#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    // The 'static' keyword makes it so you can't create instances of it. (The program will error)
    internal static class Utility
    {

        public static void SayHi(string name)
        {
            if (name == null)
            {
                Console.WriteLine("Hello!");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!");
            }
        }
    }
}
