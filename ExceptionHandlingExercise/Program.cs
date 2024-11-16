using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Create a char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', 'A', '4', '5', 'B', '6', 'C' };

            // 2) Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();

            // 3) Create a string variable with an empty string initializer - name it str
            string str = string.Empty;

            // 4) Make a foreach loop to iterate through your character array
            foreach (char character in arr)
            {
                // 5) Create a try-catch inside of your foreach loop
                try
                {
                    // 6) Inside the try block:
                    // 7) Set your string variable to each array element in your char[] using .ToString()
                    str = character.ToString();

                    // 8) Now, using int.Parse, parse your string variable and store in an int variable
                    int parsedNumber = int.Parse(str);

                    // 9) Then add each int to your list
                    numbers.Add(parsedNumber);
                }
                catch
                {
                    // 10) Inside the catch block:
                    // 11) Print the following message for unparseable characters:
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }

            // Uncomment the code below to see the numbers you successfully added to the numbers list:
            Console.WriteLine("Parsed numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }    
    }
}
