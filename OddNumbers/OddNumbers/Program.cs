/*

Name: Raghav Krishna Ranganathan
Date: 10/25/2023

Week 5 Chapter 6 HW

This C# program generates and displays odd numbers between 1 and 99. It does
this by using a "for" loop to iterate through the range of numbers, starting
from 1 and incrementing by 2 at each step. By skipping every even number,
each odd number is printed to the console, creating a list of all odd numbers
from 1 to 99.

*/

namespace OddNumbers
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Loop through numbers from 1 to 99, increment by 2
            for (int i = 1; i <= 99; i += 2)
            {
                // Print the current number
                Console.WriteLine(i);
            }
        }
    }
}