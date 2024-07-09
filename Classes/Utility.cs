using System;

namespace C__Console_App.Classes
{
    // The 'static' keyword makes it so you can't create instances of it. (the program will error)
    internal static class Utility
    {
        public static void SayHi(string name = null)
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
