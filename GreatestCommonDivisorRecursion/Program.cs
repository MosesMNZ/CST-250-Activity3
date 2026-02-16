/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Greatest Common Divisor Recursion - Extended Challenges
 * Activity 3
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first integer:");
        int num1 = Utility.ReadInt();

        Console.WriteLine("Enter second integer:");
        int num2 = Utility.ReadInt();

        // Normalize negatives
        num1 = Math.Abs(num1);
        num2 = Math.Abs(num2);

        // =========================
        // Recursive Solution
        // =========================
        Stopwatch swRecursive = Stopwatch.StartNew();
        int recursiveResult = Utility.GCDRecursive(num1, num2);
        swRecursive.Stop();

        // =========================
        // Iterative Solution
        // =========================
        Stopwatch swIterative = Stopwatch.StartNew();
        int iterativeResult = Utility.GCDIterative(num1, num2);
        swIterative.Stop();

        Console.WriteLine($"\nRecursive GCD: {recursiveResult}");
        Console.WriteLine($"Iterative GCD: {iterativeResult}");

        Console.WriteLine($"\nRecursive Time: {swRecursive.ElapsedTicks} ticks");
        Console.WriteLine($"Iterative Time: {swIterative.ElapsedTicks} ticks");

        // =========================
        // Multiple Numbers
        // =========================
        Console.WriteLine("\nEnter third integer for multi-number GCD:");
        int num3 = Math.Abs(Utility.ReadInt());

        int multiResult = Utility.GCDMultiple(new int[] { num1, num2, num3 });

        Console.WriteLine($"GCD of {num1}, {num2}, and {num3} is {multiResult}");
    }
}

public static class Utility
{
    // =========================
    // User Input with Validation
    // =========================
    public static int ReadInt()
    {
        string input;
        int number;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Try again:");
        }

        return number;
    }

    // =========================
    // Recursive Euclidean GCD
    // =========================
    public static int GCDRecursive(int a, int b)
    {
        if (b == 0)
            return a;

        return GCDRecursive(b, a % b);
    }

    // =========================
    // Iterative GCD using divisor lists
    // =========================
    public static int GCDIterative(int a, int b)
    {
        List<int> divisorsA = new List<int>();
        List<int> divisorsB = new List<int>();

        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
                divisorsA.Add(i);
        }

        for (int i = 1; i <= b; i++)
        {
            if (b % i == 0)
                divisorsB.Add(i);
        }

        int gcd = 1;

        foreach (int divisor in divisorsA)
        {
            if (divisorsB.Contains(divisor))
                gcd = divisor;
        }

        return gcd;
    }

    // =========================
    // GCD for Multiple Numbers
    // =========================
    public static int GCDMultiple(int[] numbers)
    {
        int result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            result = GCDRecursive(result, numbers[i]);
        }

        return result;
    }
}
