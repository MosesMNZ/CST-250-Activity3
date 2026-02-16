/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Greatest Common Divisor Recursion
 * Activity 3
 */

using System;

class Program
{
    // ------------------------------------------------------------
    // Start of the Main Method
    // ------------------------------------------------------------

    // (Main method content not shown in images)

    // ------------------------------------------------------------
    // End of the Main Method
    // ------------------------------------------------------------
}

// ------------------------------------------------------------
// Start of the Utility Class
// ------------------------------------------------------------
public class Utility
{
    /// <summary>
    /// Calculate the GCD using recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Declare and initialize
        int remainder = 0;

        // Base case: num2 is 0
        if (num1 == 0 || num2 == 0)
        {
            return num1;
        }
        else
        {
            remainder = num1 % num2;

            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");

            return GreatestCommonDivisor(num2, remainder);
        }
    }
}
