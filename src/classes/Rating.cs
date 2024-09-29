#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp.Classes
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    internal class Rating(double stars, int ratingCount)
    {

        public double starCount = stars;
        public int ratingCount = ratingCount;
    }
}
