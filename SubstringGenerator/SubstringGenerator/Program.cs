/*
Name: Raghav Krishna Ranganathan
Date: 10/30/2023

Week 7 Chapter 6 HW

This a C# program that prompts the user to enter their name, start index, and
length. It then extracts a substring from the user's name based on the
provided start index and length, and displays the extracted substring.

 */

using System;

namespace SubstringProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a name
            Console.WriteLine("Enter Name:");
            string userName = Console.ReadLine();

            // Prompt user to enter start index
            Console.WriteLine("Enter the start index:");
            int startIndex;
            int.TryParse(Console.ReadLine(), out startIndex);

            // Prompt user to enter length
            Console.WriteLine("Enter the length:");
            int length;
            int.TryParse(Console.ReadLine(), out length);

            // Extract substring from name based on start index and length
            string substring = userName.Substring(startIndex, length);

            // Print extracted substring
            Console.WriteLine("The substring is: " + substring);
        }
    }
}