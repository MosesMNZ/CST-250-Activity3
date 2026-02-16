/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Factorial Recursion
 * Activity 3
 */

using System;
using System.Numerics;
using FactorialRecursion.Services.BusinessLogicLayer;

class Program
{
    // ------------------------------------------------------------
    // Start of the Main Method
    // ------------------------------------------------------------
    static void Main(string[] args)
    {
        // Declare and initialize
        FactorialLogic factorialLogic = new FactorialLogic();
        int input = 0;
        BigInteger iterativeAns = 0, recursiveAns = 0;

        // Prompt the user
        Console.Write("Enter a positive number: ");

        // Get the users input
        input = Utility.ReadIntFromConsole();

        // Solve the factorial using iteration
        Console.WriteLine("Solving the factorial using iteration...");
        iterativeAns = factorialLogic.SolveIterativeFactorial(input);
        Console.WriteLine($"Answer: {iterativeAns}");

        // Solve the factorial using recursion
        Console.WriteLine("Solving the factorial using recursion...");
        recursiveAns = factorialLogic.SolveRecursiveFactorial(input);
        Console.WriteLine($"Answer: {recursiveAns}");
    }
    // ------------------------------------------------------------
    // End of the Main Method
    // ------------------------------------------------------------
}

// ------------------------------------------------------------
// Start of Utility Class
// ------------------------------------------------------------
static class Utility
{
    /// <summary>
    /// Read integer input from the console
    /// </summary>
    /// <returns></returns>
    internal static int ReadIntFromConsole()
    {
        // Declare and initialize
        string input = "";
        int number = -1;

        // Get the current input
        input = Console.ReadLine();

        // Check if the input is valid
        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid input. Please try again: ");
            input = Console.ReadLine();
        }

        return number;
    }
}
