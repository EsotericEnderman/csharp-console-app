﻿namespace CSharpConsoleApp.Classes
{

    internal class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The chef made some chicken!");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef made some salad!");
        }

        // The virtual keyword allows the class method to be overridden.
        public virtual void MakeSecretMeal()
        {
            Console.WriteLine("The chef made a secret meal...");
        }
    }
}