using System;

namespace ConsoleApp2
{
    internal class Task1CinemaHall // Cinema Revenue Calculator
    {
        public static void Execute()
        {
            Console.WriteLine("Task 1: Cinema Revenue Calculator");

            Console.Write("Enter the type of screening (Premiere, Normal, Discount):");
            string screeningType = Console.ReadLine();

            Console.Write("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns:");
            int columns = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (screeningType == "Premiere")
            {
                ticketPrice = 12.00;
            }
            else if (screeningType == "Normal")
            {
                ticketPrice = 7.50;
            }
            else if (screeningType == "Discount")
            {
                ticketPrice = 5.00;
            }
            else
            {
                Console.WriteLine("Invalid screening type.");
                return;
            }

            int totalSeats = rows * columns;
            double totalRevenue = totalSeats * ticketPrice;

            Console.WriteLine($"Total revenue: {totalRevenue:F2} BGN");
        }
    }
}
