#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    internal class ItalianChef : Chef // ItalianChef inherits functionality from the Chef class. Basically just class x extends y.
    {

        public void MakePizza()
        {
            Console.WriteLine("The chef made some pizza!");
        }

        public void MakeSpaghettiBolognese()
        {
            Console.WriteLine("The chef made some spaghetti Bolognese!");
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
