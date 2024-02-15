/*
Name: Raghav Krishna Ranganathan
Date: 11/17/2023

Chapter 9 HW


This program that calculates the cost of a desk based on the number of drawers
and the type of wood chosen by the user. It then displays the details of the
desk, including the number of drawers, the wood type, and the final price.


*/
using System;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of drawers from the user
            int numberOfDrawers = GetNumberOfDrawers();

            // Get the type of wood from the user
            char woodType = GetWoodType();

            // Calculate the cost of the desk
            double deskCost = CalculateDeskCost(numberOfDrawers, woodType);

            // Display the details of the desk
            DisplayDetails(numberOfDrawers, woodType, deskCost);
        }

        static int GetNumberOfDrawers()
        {
            // Prompt the user to enter the number of drawers
            Console.Write("Enter the number of drawers: ");

            // Read the input from the user and convert it to an integer
            int numberOfDrawers = Convert.ToInt32(Console.ReadLine());

            // Return the number of drawers
            return numberOfDrawers;
        }

        static char GetWoodType()
        {
            // Prompt the user to enter the type of wood
            Console.Write("Enter the type of wood (m for mahogany, o for oak, p for pine): ");

            // Read the input from the user and convert it to a character
            char woodType = Convert.ToChar(Console.ReadLine());

            // Return the wood type
            return woodType;
        }

        static double CalculateDeskCost(int numberOfDrawers, char woodType)
        {
            // Set the base cost of the desk based on the wood type
            double baseCost = 0;
            switch (woodType)
            {
                case 'o':
                    baseCost = 140;
                    break;
                case 'p':
                    baseCost = 100;
                    break;
                default:
                    baseCost = 180;
                    break;
            }

            // Calculate the surcharge for the drawers
            double drawerSurcharge = numberOfDrawers * 30;

            // Calculate the total cost of the desk
            double totalCost = baseCost + drawerSurcharge;

            // Return the total cost
            return totalCost;
        }

        static void DisplayDetails(int numberOfDrawers, char woodType, double deskCost)
        {
            // Set the wood type name based on the wood type
            string woodTypeName = "";
            switch (woodType)
            {
                case 'm':
                    woodTypeName = "Mahogany";
                    break;
                case 'o':
                    woodTypeName = "Oak";
                    break;
                case 'p':
                    woodTypeName = "Pine";
                    break;
                default:
                    woodTypeName = "Unknown";
                    break;
            }

            // Display the details of the desk
            Console.WriteLine("\nDesk Details \n");
            Console.WriteLine("Number of Drawers: " + numberOfDrawers);
            Console.WriteLine("Wood Type: " + woodTypeName);
            Console.WriteLine("Final Price: $" + deskCost);
        }
    }
}
