/*
Name: Raghav Krishna Ranganathan
Date: 10/13/2023

Week 4 Chapter 5 HW

HW #3

This C# program prompts the user to enter their birth month and then displays a
message indicating whether the entered month is valid or not. The program uses
a switch statement to check the value of the entered month and display the
corresponding message, along with the name of the month.

 */

using System;

namespace CheckMonth {
    class MainClass {
        public static void Main(string[] args) {

            // Prompt the user to enter their birth month
            Console.Write("Enter your birth month (1-12): ");

            // Read the input from the user and convert it to an integer
            int month = int.Parse(Console.ReadLine());

            // Check if the entered month is valid
            if (month < 1 || month > 12){

                // Display an error message if the month is invalid
                Console.WriteLine("Error: Invalid month entered.");
            }

            else {

                // Use a switch statement to determine month name based on the entered number
                // Prints a validity statement along with month name

                switch (month) {

                    case 1:
                        Console.WriteLine("January (1) is a valid month.");
                        break;

                    case 2:
                        Console.WriteLine("February (2) is a valid month.");
                        break;

                    case 3:
                        Console.WriteLine("March (3) is a valid month.");
                        break;

                    case 4:
                        Console.WriteLine("April (4) is a valid month.");
                        break;

                    case 5:
                        Console.WriteLine("May (5) is a valid month.");
                        break;

                    case 6:
                        Console.WriteLine("June (6) is a valid month.");
                        break;

                    case 7:
                        Console.WriteLine("July (7) is a valid month.");
                        break;

                    case 8:
                        Console.WriteLine("August (8) is a valid month.");
                        break;

                    case 9:
                        Console.WriteLine("September (9) is a valid month.");
                        break;

                    case 10:
                        Console.WriteLine("October (10) is a valid month.");
                        break;

                    case 11:
                        Console.WriteLine("November (11) is a valid month.");
                        break;

                    case 12:
                        Console.WriteLine("December (12) is a valid month.");
                        break;
                }
            }
        }
    }
}