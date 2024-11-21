using System;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a task to execute (1-5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1CinemaHall.Execute();
                    break;
                case "2":
                    Task2FishingTrip.Execute();
                    break;
                case "3":
                    Task3SalaryDeduction.Execute();
                    break;
                case "4":
                    Task4StepsToReachGoal.Execute();
                    break;
                case "5":
                    Task5BirthdayCake.Execute();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
