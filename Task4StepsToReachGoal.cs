using System;

namespace ConsoleApp2
{
    internal class Task4StepsToReachGoal // Steps to Reach a Goal
    {
        public static void Execute()
        {
            const int goal = 10000; 
            int totalSteps = 0;

            while (totalSteps < goal)
            {
                Console.Write("Enter steps or 'Going home': ");
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    Console.Write("Enter steps taken while going home: ");
                    int goingHomeSteps = int.Parse(Console.ReadLine());
                    totalSteps += goingHomeSteps;
                    CheckGoal(totalSteps, goal);
                    return;
                }
                else
                {
                    int steps = int.Parse(input);
                    totalSteps += steps;

                    if (CheckGoal(totalSteps, goal))
                    {
                        return; 
                    }
                }
            }
        }

        private static bool CheckGoal(int totalSteps, int goal)
        {
            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                return true;
            }
            else
            {
                int difference = goal - totalSteps;
                Console.WriteLine($"{difference} more steps to reach goal.");
                return false;
            }
        }
    }
}
