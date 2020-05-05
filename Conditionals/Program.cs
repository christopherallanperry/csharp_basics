using System;

namespace Conditionals
{
  class Program
  {
    static void Main(string[] args)
    {
      IsNumberValid();

      MaxNumber();

      ImageOrientation();

      SpeedCamera();
    }

    /// <summary>
    /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
    /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
    /// applications where values entered into input boxes need to be validated.)
    /// </summary>
    static void IsNumberValid()
    {
      Console.WriteLine("Enter a number between 1 and 10");
      var input = Console.ReadLine();
      var number = Convert.ToInt32(input);
      if (number >= 0 && number <= 10)
      {
        Console.WriteLine("Valid");
      }
      else
      {
        Console.WriteLine("Invalid");
      }
    }


    /// <summary>
    /// Write a program which takes two numbers from the console and displays the maximum of the two.
    /// </summary>

    static void MaxNumber()
    {
      Console.WriteLine("Enter your first number");
      var firstNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your second number");
      var secondNum = Convert.ToInt32(Console.ReadLine());

      if (firstNum > secondNum)
      {
        Console.WriteLine("The first number (" + firstNum + ") is greater than the second number (" + secondNum + ").");
      }
      else if (secondNum > firstNum)
      {
        Console.WriteLine("The first number (" + firstNum + ") is smaller than the second number (" + secondNum + ").");
      }
      else
      {
        Console.WriteLine("The numbers are the same");
      }
    }

    /// <summary>
    /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
    /// is landscape or portrait.
    /// </summary>
    static void ImageOrientation()
    {
      Console.WriteLine("Enter the image width");
      var width = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the image height");
      var height = Convert.ToInt32(Console.ReadLine());
      var orientation = (width > height) ? "landscape" : "portrait";

      Console.WriteLine("The image is in a " + orientation + " format.");
    }



    /// <summary>
    /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
    /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
    /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
    /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
    /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
    /// the console. If the number of demerit points is above 12, the program should display License Suspended.
    /// </summary>
    static void SpeedCamera()
    {
      Console.WriteLine("Enter the speed limit");
      var speedLimit = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the vehicle speed");
      var vehicleSpeed = Convert.ToInt32(Console.ReadLine());

      double excess;
      double demeritPoints = 0;

      if (vehicleSpeed > speedLimit + 4)
      {
        excess = vehicleSpeed - speedLimit;
        demeritPoints = Math.Truncate(excess / 5);
      }

      if (demeritPoints >= 12)
      {
        Console.WriteLine("Licence suspended");
      }
      else if (demeritPoints > 0)
      {
        Console.WriteLine(demeritPoints + " demerit point(s) incurred");
      }
      else
      {
        Console.WriteLine("OK");
      }
    }
  }
}
