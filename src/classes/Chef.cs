#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
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
