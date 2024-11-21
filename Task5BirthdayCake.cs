using System;

namespace ConsoleApp2
{
    internal class Task5BirthdayCake // Birthday Cake
    {
        public static void Execute()
        {
            Console.Write("Enter the width of the cake: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the cake: ");
            int length = int.Parse(Console.ReadLine());

            int totalPieces = width * length; 
            int piecesTaken = 0;

            while (piecesTaken < totalPieces)
            {
                Console.Write("Enter pieces taken or 'STOP': ");
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    int piecesLeft = totalPieces - piecesTaken;
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    return;
                }

                int pieces = int.Parse(input);
                piecesTaken += pieces;

                if (piecesTaken > totalPieces)
                {
                    int piecesNeeded = piecesTaken - totalPieces;
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    return;
                }
            }
        }
    }
}
