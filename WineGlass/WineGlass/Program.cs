/*
Name: Raghav Krishna Ranganathan
Date: 10/01/2023

Week 2 Chapter 2 HW

HW #1

This program uses simple print statements to display a representation of a
cyan-colored wineglass in the terminal, made out of multiple copies of the
letter "X" in a specific order and arrangement. 

 */
using System;
namespace WineGlass {
    class MainClass {
        public static void Main(string[] args) {
            // Set the console text color to cyan (for additional creativity)
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Print the top of the wine glass
            Console.WriteLine("XXXXXXXXXXX");

            // Print the upper part of the wine glass
            Console.WriteLine(" X       X ");
            Console.WriteLine("  X     X  ");

            // Print the stem of the wine glass
            Console.WriteLine("   XXXXX   ");
            Console.WriteLine("     X     ");
            Console.WriteLine("     X     ");

            // Print the base of the wine glass
            Console.WriteLine("   XXXXX   ");
        }
    }
}