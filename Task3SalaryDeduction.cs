using System;

namespace ConsoleApp2
{
    internal class Task3SalaryDeduction // Salary Deduction
    {
        public static void Execute()
        {
            Console.Write("Number of open tabs:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the salary:");
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the name of website {i + 1}:");
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine($"Remaining salary: {salary} BGN");
        }
    }
}
