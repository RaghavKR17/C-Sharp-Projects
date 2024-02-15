/*
Name: Raghav Krishna Ranganathan
Date: 10/23/2023

MIDTERM EXAM

This C# program that prompts the user to enter two numbers above 20 and
calculates the sum of all numbers between those two numbers, by using
a for-loop and 3 variables.

 */

using System;

namespace MidTerm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Prompt the user to enter two numbers above 20
            Console.WriteLine("Please enter two numbers above 20:");

            // Read the first number entered by the user and store it in the 'min' variable
            int min = int.Parse(Console.ReadLine());

            // Read the second number entered by the user and store it in the 'max' variable
            int max = int.Parse(Console.ReadLine());

            // Check if either of the numbers is less than 20
            if (min < 20 || max < 20)
            {
                // Display an error message if either of the numbers is less than 20
                Console.WriteLine("Error: Numbers must be above 20.");
            }
            else
            {
                // Initialize a variable to store the sum of all numbers between 'min' and 'max'
                int sum = 0;

                // Iterate through all numbers between 'min' and 'max' (EXLUDING MIN AND MAX)
                for (int i = min + 1; i < max; i++)
                {
                    // Add each number to the sum
                    sum += i;
                }

                // Display the sum of all numbers between 'min' and 'max'
                Console.WriteLine("The sum of all numbers between " + min + " and " + max + " is " + sum + ".");
            }
        }
    }
}
