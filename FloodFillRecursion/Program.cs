/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Flood Fill Recursion
 * Activity 3
 */

using System;
using FloodFillRecursion.Models;

class Program
{
    // ------------------------------------------------------------
    // Start of the Main Method
    // ------------------------------------------------------------
    static void Main(string[] args)
    {
        // Create a new BoardModel (size 20, 3 shapes)
        BoardModel board = new BoardModel(20, 3);

        // Print the board
        Utility.PrintBoard(board);

        Console.ResetColor();
    }
    // ------------------------------------------------------------
    // End of the Main Method
    // ------------------------------------------------------------
}

// ------------------------------------------------------------
// Utility Class
// ------------------------------------------------------------
static class Utility
{
    /// <summary>
    /// Print the board to the console
    /// </summary>
    public static void PrintBoard(BoardModel board)
    {
        Console.ForegroundColor = ConsoleColor.White;

        // Print top spacing for alignment
        Console.Write("   ");

        // Print column numbers
        for (int colNum = 0; colNum < board.Size; colNum++)
        {
            Console.Write($"{colNum + 1,2} ");
        }

        Console.WriteLine();

        // Loop through rows
        for (int row = 0; row < board.Size; row++)
        {
            // Print row number
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{row + 1,2} ");

            // Loop through columns
            for (int col = 0; col < board.Size; col++)
            {
                if (board.Grid[row, col].Contents == "W")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" W ");
                }
                else if (board.Grid[row, col].Contents == "E")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" . ");
                }
                else
                {
                    Console.Write("   ");
                }
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }
}
