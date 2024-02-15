/*

Name: Raghav Krishna Ranganathan
Date: 11/09/2023

Chapter 8 HW

This program lets users input seven different tip amounts, calculates the
average of these tips, and provides a detailed analysis of how each tip
compares to the average. The program displays the average tip amount and,
for each entered tip, it shows whether it's "ABOVE" or "BELOW" the average,
along with the absolute difference. This tool is handy for individuals looking
to understand how each of their tips compares to the overall average.

*/

using System;

namespace TipList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store the tips
            double[] tips = new double[7];

            // Prompt the user to enter the tips and store them in the array
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter Tip: ");
                tips[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate the total of all the tips
            double total = 0;
            foreach (double tip in tips)
            {
                total += tip;
            }

            // Calculate the average tip
            double average = total / 7;

            // Display the average tip
            Console.WriteLine("\nAverage Tip: " + average);
            Console.WriteLine("");

            // Compare each tip to the average and display the difference
            for (int i = 0; i < 7; i++)
            {
                double difference = tips[i] - average;
                string message = difference >= 0 ? "ABOVE" : "BELOW";
                Console.WriteLine("Tip " + (i + 1) + ": " + tips[i] + " (" + Math.Abs(difference) + " " + message + " average)");
            }
        }
    }
}
