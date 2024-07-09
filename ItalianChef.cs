using System;

namespace C__Console_App
{
    internal class ItalianChef:Chef // ItalianChef inherits functionality from the Chef class. Basically just class x extends y.
    {
        public void MakePizza()
        {
            Console.WriteLine("The chef made some pizza!");
        }

        public void MakeSpaghettiBolognese()
        {
            Console.WriteLine("The chef made some spaghetti bolognese!");
        }

        public void MakePasta()
        {
            Console.WriteLine("The chef made some pasta!");
        }

        // Add the override keyword to override a super class method.
        public override void MakeSecretMeal()
        {
            Console.WriteLine("The chef made a secret meal... but Italian");
        }
    }
}
