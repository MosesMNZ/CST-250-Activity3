/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/16/2026
 * Count To One Recursion - Challenges
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        string input = "";

        Console.Write("Enter any integer (positive, negative, or zero): ");
        input = Console.ReadLine();

        while (!int.TryParse(input, out choice))
        {
            Console.WriteLine("Invalid number");
            Console.Write("Enter any integer: ");
            input = Console.ReadLine();
        }

        int counter = 0;
        int result = Utility.CountToOne(choice, ref counter);

        Console.WriteLine($"\nThe end number is {result}");
        Console.WriteLine($"Total recursive calls: {counter}");
    }
}

static class Utility
{
    internal static int CountToOne(int num, ref int counter)
    {
        counter++; // Challenge 1: Count recursive calls

        Console.WriteLine($"Step {counter}: Current number = {num}");

        // Challenge 5: Handle 0
        if (num == 0)
        {
            Console.WriteLine("Zero detected. Converting to 1.");
            return 1;
        }

        // Challenge 5: Handle negative numbers
        if (num < 0)
        {
            Console.WriteLine("Negative detected. Converting to positive.");
            num = Math.Abs(num);
        }

        // Base case
        if (num == 1)
        {
            return 1;
        }

        // Challenge 4: Multiply if divisible by 5
        if (num % 5 == 0)
        {
            Console.WriteLine("Divisible by 5. Multiply by 2.");
            return CountToOne(num * 2, ref counter);
        }

        // Challenge 3: Divide by larger numbers first
        if (num % 4 == 0)
        {
            Console.WriteLine("Divisible by 4. Divide by 4.");
            return CountToOne(num / 4, ref counter);
        }

        if (num % 3 == 0)
        {
            Console.WriteLine("Divisible by 3. Divide by 3.");
            return CountToOne(num / 3, ref counter);
        }

        // Even numbers
        if (num % 2 == 0)
        {
            Console.WriteLine("Even number. Divide by 2.");
            return CountToOne(num / 2, ref counter);
        }

        // Challenge 2: Instead of +1, subtract 1 for odd numbers
        Console.WriteLine("Odd number. Subtract 1.");
        return CountToOne(num - 1, ref counter);
    }
}
