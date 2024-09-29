using CSharpConsoleApp.Classes;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CSharpConsoleApp
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

  internal class CSharpConsoleApp
  {

    // Can also be at the bottom.
    static void SayHi(string name = "", int age = -1)
    {
      Console.WriteLine(
      ("Hello " + name).TrimEnd() + "!" + (age != -1 ? (" You are " + age + " years old.") : "")
      );
    }

    static decimal Cube(decimal number)
    {
      return number * number * number;
    }

    static int GetMax(int number1, int number2, int number3)
    {
      if (number1 > number2 && number1 > number3) return number1;
      if (number2 > number3) return number2;
      return number3;
    }

    /// <summary>
    /// Gets the day of the week from the index. Days start with Monday.
    /// </summary>
    /// <param name="dayNumberZeroIndex"></param>
    /// <returns>"Monday" | "Tuesday" | "Wednesday" | "Thursday" | "Friday" | "Saturday" | "Sunday"</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    static string GetDayOfTheWeek(int dayNumberZeroIndex)
    {
            return dayNumberZeroIndex switch
            {
                0 => "Monday",
                1 => "Tuesday",
                2 => "Wednesday",
                3 => "Thursday",
                4 => "Friday",
                5 => "Saturday",
                6 => "Sunday",
                _ => throw new ArgumentOutOfRangeException("Invalid day of the week. Day of the week must be an int from 0-6. Received " + dayNumberZeroIndex + " instead." + " " + dayNumberZeroIndex + " " + (dayNumberZeroIndex > 6 ? "> 6" : "< 0")),
            };
        }

    static decimal Exponentiate(decimal baseNumber, int exponentNumber)
    {
      if (baseNumber == 0 && exponentNumber == 0) throw new InvalidOperationException("0 ^ 0 is undefined.");

      decimal product = 1;

      for (int i = 1; i <= Math.Abs(exponentNumber); i++)
      {
        product *= baseNumber;
      }

      return exponentNumber < 0 ? 1 / product : product;
    }

    static void Main()
    {
      // Console.WriteLine only takes one argument.
      Console.WriteLine("Hello world!");

      Console.WriteLine("   /|");
      Console.WriteLine("  / |");
      Console.WriteLine(" /  |");
      Console.WriteLine("/___|");


      Console.WriteLine();

      // The order matters.
      Console.WriteLine("/___|");
      Console.WriteLine("   /|");
      Console.WriteLine(" /  |");
      Console.WriteLine("   /|");

      Console.WriteLine();

      string characterName = "Tom";
      int characterAge;
      characterAge = 35;

      Console.WriteLine("There once was a man named " + characterName);
      Console.WriteLine("He was " + characterAge + " years old");

      characterName = "Mike";

      Console.WriteLine("He really liked the name " + characterName);
      Console.WriteLine("But he didn't like being " + characterAge);

      // Prints a blank line.
      Console.WriteLine();

      string phrase = "Giraffe Academy";
      char grade = 'A';

      char firstLetter = phrase[0];

      int wholeNumber = 10;
      int negativeNumber = -10;

      Console.WriteLine(phrase);
      Console.WriteLine(grade);


      Console.WriteLine();

      Console.WriteLine(firstLetter);


      Console.WriteLine();

      Console.WriteLine(wholeNumber);
      Console.WriteLine(negativeNumber);

      // float, double, and decimal types are used to store decimal numbers.
      // Ordered least to most accurate.
      // float = 32 bit (7 digits)
      // double = 64 bit (15-16 digits)
      // decimal = 128 bit (28-29 significant digits)

      // Underscores can be used to separate numbers to make them more readable.

      float someFloatNumber = 17.53365624_5_5_55315f;
      float someOtherFloatNumber = 175.532525342F;

      // Floats (7 digits)

      Console.WriteLine();

      // Prints 17.53368
      Console.WriteLine(someFloatNumber);

      // Prints 175.5325
      Console.WriteLine(someOtherFloatNumber);

      double someDoubleNumber = 160_525.509509509509509509d;
      double pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286D;

      double nonDecimalDouble = 150_500_500_500_500_500_500D;

      // Doubles (15-16 digits)

      // 15 with decimal point
      // 16 without

      Console.WriteLine();

      // Prints 160525.50950951
      Console.WriteLine(someDoubleNumber);

      // Prints 3.14159265358979
      Console.WriteLine(pi);

      // Prints 1.50500500500501E+20 = 1.50500500500501 * 10^20
      Console.WriteLine(nonDecimalDouble);

      // Decimal (28-29 significant digits)
      // 28 with decimal point
      // 29 without

      Console.WriteLine();

      // "M" or "m" suffix for decimal.
      decimal moreAccuratePI = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566M;

      // Prints 3.1415926535897932384626433833
      Console.WriteLine(moreAccuratePI);

      // Booleans

      bool someBooleanValue = true;
      bool someOtherBooleanValue = false;

      Console.WriteLine();

      Console.WriteLine(someBooleanValue);
      Console.WriteLine(someOtherBooleanValue);

      Console.WriteLine();

      Console.WriteLine(30);
      Console.WriteLine(false);

      // Newline character & escaped characters.
      Console.WriteLine("\"Giraffe\nAcademy\"");

      Console.WriteLine();

      // Console.Write writes to the current line.
      // Console.WriteLine writes to a new line.

      // Concatenation
      string sentence = "\"Giraffe\nAcademy\"" + " is cool";

      Console.WriteLine(sentence);

      // 0123456789...
      string giraffeAcademy = "Giraffe Academy";
      Console.WriteLine(giraffeAcademy);
      Console.WriteLine(giraffeAcademy.Length);

      Console.WriteLine(giraffeAcademy.Length);

      // To upper- and lowercase.
      Console.WriteLine(giraffeAcademy.ToUpper());
      Console.WriteLine(giraffeAcademy.ToLower());

      // Prints True.
      Console.WriteLine(giraffeAcademy.Contains("Academy"));

      // Prints False.
      Console.WriteLine(giraffeAcademy.Contains("School"));

      Console.WriteLine("First character is: " + giraffeAcademy[0]);
      Console.WriteLine("Third character is: " + giraffeAcademy[2]);

      Console.WriteLine("Ninth character is: " + giraffeAcademy[8]);

      Console.WriteLine(giraffeAcademy.IndexOf("Academy"));
      Console.WriteLine(giraffeAcademy.IndexOf('f'));

      // There is no "z" in the string, so it returns -1.
      Console.WriteLine(giraffeAcademy.IndexOf('z'));

      // Prints "Aca". Gets 3 characters starting with index 8.
      Console.WriteLine(giraffeAcademy.Substring(8, 3));

      Console.WriteLine();

      Console.WriteLine(40);

      Console.WriteLine(-5.783);

      Console.WriteLine(3.14159);

      // Prints 13
      Console.WriteLine(5 + 8);

      Console.WriteLine(5 - 8);

      // Prints 0
      Console.WriteLine(5 / 8);

      // Prints 1 => rounds the number down.
      Console.WriteLine(13 / 8);

      // Prints 1.625
      Console.WriteLine(13F / 8F);

      // 5 (mod 2) => 1
      Console.WriteLine(5 % 2);

      // Prints 10.
      Console.WriteLine(4 + 2 * 3);

      // Prints 18.
      Console.WriteLine((4 + 2) * 3);

      // Prints 13.1
      Console.WriteLine(5 + 8.1);

      // Prints 13.1
      Console.WriteLine(5.0 + 8.1);

      // Prints 2.
      Console.WriteLine(5 / 2);

      // Prints 2.5
      Console.WriteLine(5 / 2.0);

      int number = 6;
      Console.WriteLine(number);

      number++;
      Console.WriteLine(number);

      number--;
      Console.WriteLine(number);

      // Absolute value.
      Console.WriteLine(Math.Abs(-40));

      // Power. 3^4 = 81
      Console.WriteLine(Math.Pow(3, 4));

      Console.WriteLine(Math.Pow(16, 1.5));

      Console.WriteLine(Math.Sqrt(Math.Pow(5, 2) - Math.Pow(4, 2)));

      // Returns 90.
      Console.WriteLine(Math.Max(4, 90));

      // Returns 4.
      Console.WriteLine(Math.Min(4, 90));

      Console.WriteLine(Math.Round(4.4));
      Console.WriteLine(Math.Round(4.5));

      // Prints 1.
      Console.WriteLine(Math.Sin(Math.PI / 2));

      // Prints 0 (or I guess 6.12303176911189E-17, close enough).
      Console.WriteLine(Math.Cos(Math.PI / 2));

      // Prints 1.
      Console.WriteLine(Math.Tan(Math.PI / 4));

      Console.WriteLine();

      //0123456789 1011121314
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

      Console.WriteLine(numbers);

      // 0, 1, 2,3,4,
      int[] luckyNumbers = { 1, 3, 8, 11, 13, 16, 23, 42, 44 };

      string[] friends = new string[2];
      friends[0] = "rolyPolyVole";
      friends.Append("Crafty_Crafter2");
      Console.WriteLine(friends.Length); // 2.

      // Update an element of an array.
      luckyNumbers[1] = 7;

      Console.WriteLine(luckyNumbers[0]);

      Console.WriteLine();

      SayHi("Esoteric Enderman", 15);
      SayHi("Esoteric Enderman");
      SayHi();

      Console.WriteLine();

      Console.WriteLine(Cube(29.4M));

      decimal inputNumber = 500M;
      decimal cubedInputNumber = Cube(inputNumber);

      Console.WriteLine(cubedInputNumber);

      Console.WriteLine();

      bool isMale = true;
      bool isTall = true;

      if (isMale && isTall)
      {
        Console.WriteLine("You are a tall male.");
      }
      else if (isMale)
      {
        Console.WriteLine("You are not tall, but male.");
      }
      else if (isTall)
      {
        Console.WriteLine("You are tall, but not male");
      }
      else
      {
        Console.WriteLine("You are not male and not tall.");
      }

      if (isMale || isTall)
      {
        Console.WriteLine("You are either male, or tall, or both.");
      }
      else
      {
        Console.WriteLine("You are neither male nor tall.");
      }


      Console.WriteLine();

      Console.WriteLine(GetMax(5, 7, 6));

      Console.WriteLine();

      Console.WriteLine(GetDayOfTheWeek(4));

      Console.WriteLine();

      int index = 1;

      while (index <= 5)
      {
        Console.WriteLine(index);
        index++;
      }

      // Executes code before it checks the conditions.
      do
      {
        Console.WriteLine(index);
      } while (index < 1);

      Console.WriteLine();

      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine(i);
      }

      Console.WriteLine();

      Console.WriteLine(luckyNumbers);

      for (int i = 0; i < luckyNumbers.Length; i++)
      {
        Console.WriteLine(luckyNumbers[i]);
      }

      Console.WriteLine();

      Console.WriteLine(Exponentiate(2, 31) - 1); // 2147483647
      Console.WriteLine(Exponentiate(2, -1));
      Console.WriteLine(Exponentiate(5, -10));

      Console.WriteLine();

      int[,] numberGrid =
            {
                { 0, 0, },
                { 1, 1, },
                { 2, 2, }
            };

      Console.WriteLine(numberGrid[1, 0]);

      /*
       * Interesting comment.
       */

      /*
       Multi-line comment.
       */

      /// Documentation comment.

      Console.WriteLine();

      Student Jim = new Student("Jim", "Business", 2.8);
      Student Pam = new Student("Pam", "Art", 3.6);

      Console.WriteLine(Jim.HasHonours());
      Console.WriteLine(Pam.HasHonours());

      Console.WriteLine();

      Rating movie1Rating = new Rating(4.6, 7203);
      Movie movie1 = new Movie("The Avengers", "Joss Whedon", movie1Rating, MovieAgeRating.PG_13);

      // movie1.AgeRating = "a"; will error.

      Console.WriteLine(movie1);

      Rating movie2Rating = new Rating(4.4, 8905);
      Movie movie2 = new Movie("Shrek", "Adam Adamson", movie2Rating, MovieAgeRating.PG);

      Console.WriteLine(movie2);

      Console.WriteLine();

      Console.WriteLine(Song.SongCount); // You can't use "Song.title" because it belongs to instances of the class, not the class itself.

      Song holiday = new Song("Holiday", ["Green Day"], 200);
      Song kashmir = new Song("Kashmir", ["Led Zeppelin"], 150);

      Console.WriteLine(holiday.title);
      Console.WriteLine(kashmir.title); // Can't do "Kasmir.songCount".

      Console.WriteLine(Song.SongCount);

      Console.WriteLine();

      Console.WriteLine(Math.Sqrt(144)); // Math is a static class. (You can't create instances of it, it will error)
      Utility.SayHi("Esoteric Enderman");

      Console.WriteLine();

      Chef chef = new Chef(); // Super class.
      chef.MakeChicken();

      ItalianChef italianChef = new ItalianChef(); // Sub-class.
      italianChef.MakeChicken();

      italianChef.MakePizza();
      italianChef.MakePasta();
      italianChef.MakeSpaghettiBolognese();

      chef.MakeSecretMeal();
      italianChef.MakeSecretMeal(); // ItalianChef#MakeSecretMeal overrides Chef#MakeSecretMeal and also extends the Chef class.

      Console.WriteLine();

      try
      {
        Console.Write("Enter a number: ");
        decimal inputNum1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter a number: ");
        decimal inputNum2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine(inputNum1 / inputNum2);
      }
      catch (Exception exception)
      { // Catches all exceptions, use specific exception types to catch specific exceptions. E.g., DivideByZeroException.
        Console.Write(exception.ToString());
      } // Add more catches on top of the block, to catch more specific exceptions.
      finally
      {
        Console.WriteLine("This will always be executed! Even if the 'try' block above fails.");
        // Code that will always get executed.
        // Wait this is actually really useful...
        // Like in Slime Bot you can have a try catch to do something when joining the server, and also code to store the server in the database, in a finally block.
      }

      Console.WriteLine();

      Book slimeBotDocs = new Book("Slime Bot Documentation", "Esoteric Enderman", 304, "The Slimy Swamp");
      Console.WriteLine(slimeBotDocs);
      Console.WriteLine(slimeBotDocs.title);
      Console.WriteLine(slimeBotDocs.authorName);
      Console.WriteLine(slimeBotDocs.pageCount);
      Console.WriteLine(slimeBotDocs.genre);

      Book tssHistory = new Book("The History of The Slimy Swamp, I guess", "Esoteric Enderman", 6030, "The Slimy Swamp");
      Console.WriteLine(tssHistory);
      Console.WriteLine(tssHistory.title);
      Console.WriteLine(tssHistory.authorName);
      Console.WriteLine(tssHistory.pageCount);
      Console.WriteLine(tssHistory.genre);

      Console.WriteLine();

      string secretWord = "giraffe";
      string guess = "";

      int guessesLeft = 3;

      while (guess != secretWord && guessesLeft > 0)
      {
        Console.Write("Enter your guess " + "(" + guessesLeft + " guesses remaining" + "): ");
        guess = Console.ReadLine() ?? "";
        guessesLeft--;
      }

      if (guessesLeft != 0) Console.WriteLine("GG!"); else Console.WriteLine("L");

      string secretWord2 = "monkey";
      guessesLeft = 3;

      do
      {
        Console.Write("Enter your guess " + "(" + guessesLeft + " guesses remaining" + "): ");
        guess = Console.ReadLine() ?? "";
        guessesLeft--;
      }
      while (guess != secretWord2 && guessesLeft > 0);

      if (guessesLeft != 0) Console.WriteLine("GG!"); else Console.WriteLine("L");

      Console.WriteLine();

      Console.Write("Enter a number: ");
      decimal num1 = Convert.ToDecimal(Console.ReadLine());

      Console.WriteLine();

      Console.Write("Enter an operator (+, -, /, *): ");
      string operatorInput = Console.ReadLine() ?? "";

      Console.WriteLine();

      Console.Write("Enter another number: ");
      decimal num2 = Convert.ToDecimal(Console.ReadLine());

      if (operatorInput == "+")
      {
        Console.WriteLine("(" + num1 + ") + (" + num2 + ") = " + (num1 + num2));
      }
      else if (operatorInput == "-")
      {
        Console.WriteLine("(" + num1 + ") - (" + num2 + ") = " + (num1 - num2));
      }
      else if (operatorInput == "*")
      {
        Console.WriteLine("(" + num1 + ") * (" + num2 + ") = " + (num1 * num2));
      }
      else if (operatorInput == "/")
      {
        Console.WriteLine("(" + num1 + ") / (" + num2 + ") = " + (num1 / num2));
      }
      else
      {
        Console.WriteLine("Unsupported or invalid operator.");
      }

      Console.WriteLine();

      Console.Write("Enter a colour: ");
      string colour = Console.ReadLine() ?? "";

      Console.Write("Enter a plural noun: ");
      string pluralNoun = Console.ReadLine() ?? "";

      Console.Write("Enter a celebrity's name: ");
      string celebrityName = Console.ReadLine() ?? "";

      Console.WriteLine("Roses are " + colour.ToLower());
      Console.WriteLine(pluralNoun[0].ToString().ToUpper() + pluralNoun.Substring(1).ToLower() + " are blue");
      Console.WriteLine("I love " + celebrityName[0].ToString().ToUpper() + celebrityName.Substring(1).ToLower());

      Console.WriteLine();

      // Returns 4356.
      Console.WriteLine("43" + "56");

      int number1 = Convert.ToInt32("45");
      int number2 = Convert.ToInt32("55");

      Console.WriteLine(number1 + number2);

      // Console.WriteLine(Convert.ToInt32("34abcdefghijklmnopqrstuvwxyz")) => returns error.

      Console.Write("Enter a number: ");
      decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Enter another number: ");
      decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());

      // Brackets needed.
      Console.WriteLine(inputNumber1 + " + " + inputNumber2 + " = " + (inputNumber1 + inputNumber2));

      Console.WriteLine();

      Console.Write("This goes on the same line");
      Console.Write(" as this.");

      Console.WriteLine();

      Console.Write("Enter your name: ");

      // Waits for input from user. Doesn't close the tab straight away.
      string userName = Console.ReadLine() ?? "";

      Console.Write("Enter your age: ");

      string userAge = Console.ReadLine() ?? "";

      Console.WriteLine("You entered: " + userName + " and " + userAge);

      Console.WriteLine("Hey " + userName + "! You are " + userAge + " years old.");

      // Make sure to close the program before using it again.
      // Waits for input from user. Doesn't close the tab straight away.
      Console.ReadLine();
    }
  }
}
