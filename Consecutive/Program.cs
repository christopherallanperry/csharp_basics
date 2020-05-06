using System;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Consecutive();
        }


        // 1- Write a program and ask the user to enter a few numbers separated
        // by a hyphen.
        // Work out if the numbers are consecutive. For example,
        // if the input is "5-6-7-8-9" or "20-19-18-17-16", display a
        // message: "Consecutive"; otherwise, display "Not Consecutive".

        static void Consecutive()
        {
            Console.WriteLine("Enter a series of numbers separated by a hyphen");
            Console.WriteLine("E.g. 110-65-2-42-11");
            string series = Console.ReadLine();
            Console.WriteLine("You entered: " + series);

            var integers = series.Split('-');
            Array.Sort(integers);

            for (var i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }

            Console.WriteLine("Integers is now [{0}]", string.Join(", ", integers));
        }
    }
}
