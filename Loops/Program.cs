using System;

namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      // CountNumbers();

      // SumNumbers();

      //   Factorial();

      //   GuessTheNumber();

      MaxNumber();
    }

    /// 1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
    /// Display the count on the console.

    static void CountNumbers()
    {
      var count = 0;
      var value = 100;
      for (var i = 1; i <= value; i++)
      {
        if (i % 3 == 0)
        {
          count++;
        }
      }

      Console.WriteLine("The count of numbers divisible by 3, with no remainder in " + value + ", is " + count);
    }

    /// 2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
    /// Calculate the sum of all the previously entered numbers and display it on the console.

    static void SumNumbers()
    {
      int sum = 0;

      while (true)
      {
        Console.WriteLine("Enter a number, or \"ok\" to exit");
        string input = Console.ReadLine();

        if (input.ToLower() == "ok")
        {
          break;
        }

        sum += Convert.ToInt32(input);
      }

      Console.WriteLine("The sum of the numbers entered is " + sum);
    }

    /// 3 - Write a program and ask the user to enter a number. 
    /// Compute the factorial of the number and print it on the console.
    /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

    static void Factorial()
    {
      // Console.WriteLine("Hello world");

      Console.WriteLine("Please enter a number");

      var input = Convert.ToInt32(Console.ReadLine());
      int factorial = 1;

      for (var i = 0; i < input; i++)
      {
        factorial = factorial * (input - i);
      }

      Console.WriteLine("Based on the input value of " + input + ", the factorial value is " + factorial);
    }

    /// 4 - Write a program that picks a random number between 1 and 10. 
    /// Give the user 4 chances to guess the number.
    /// If the user guesses the number, display “You won"; otherwise, display “You lost".
    /// (To make sure the program is behaving correctly, you can display the secret number on the console first.)

    static void GuessTheNumber()
    {
      var random = new Random();
      var secretNumber = random.Next(1, 10);
      int guessCount = 0;
      int maxAttempts = 4;


      Console.WriteLine("Find the number between 1 and 10:");
      Console.WriteLine("Enter a guess...");
      Console.WriteLine("");
      //   Console.WriteLine(secretNumber);
      //   Console.WriteLine("");

      for (var i = 0; i < maxAttempts; i++)
      {
        var input = Convert.ToInt32(Console.ReadLine());
        if (input == secretNumber && guessCount < maxAttempts)
        {
          Console.WriteLine("You won!");
          Console.WriteLine("");
          break;
        }
        else if (input != secretNumber && guessCount == maxAttempts - 1)
        {
          Console.WriteLine("You lost!");
          Console.WriteLine("");
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Not this time. Guess again");
          Console.WriteLine("");
        }
        guessCount = guessCount + 1;
        // Console.WriteLine("Guess count is: " + guessCount + ". i is " + i + ".");
      }

      Console.WriteLine("Game Over!");
      Console.WriteLine("The secret number was " + secretNumber);
    }

    /// 5 - Write a program and ask the user to enter a series of numbers separated by comma.
    /// Find the maximum of the numbers and display it on the console.
    /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

    static void MaxNumber()
    {
    //   Console.WriteLine("Here again");

    
    }
  }
}
