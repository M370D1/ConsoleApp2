using System;

namespace ConsoleApp2
{
    internal class Task2FishingTrip // Fishing Trip Calculatio
    {
        public static void Execute()
        {
            Console.Write("Enter the group budget: ");
            int budget = int.Parse(Console.ReadLine());

            Console.Write("Enter the season (Spring, Summer, Autumn, Winter): ");
            string season = Console.ReadLine();

            Console.Write("Enter the number of fishermen: ");
            int fishermenCount = int.Parse(Console.ReadLine());

            double basePrice = 0;

            if (season == "Spring")
            {
                basePrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                basePrice = 4200;
            }
            else if (season == "Winter")
            {
                basePrice = 2600;
            }

            double groupDiscount = 0;

            if (fishermenCount <= 6)
            {
                groupDiscount = 0.10; 
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11)
            {
                groupDiscount = 0.15; 
            }
            else if (fishermenCount >= 12)
            {
                groupDiscount = 0.25; 
            }

            double totalPrice = basePrice * (1 - groupDiscount);

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                totalPrice *= 0.95; 
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have enough money! The total price is {totalPrice:F2} BGN.");
            }
            else
            {
                Console.WriteLine($"No! You don't have enough money. You need {totalPrice - budget:F2} more BGN.");
            }
        }
    }
}
