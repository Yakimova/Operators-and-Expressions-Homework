using System;
/*
    Problem 1. Odd or Even Integers
    Write an expression that checks if given integer is odd or even.
 */
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        bool even = (number % 2 == 0);
        if (even)
            Console.WriteLine("The number is even.");
        else
            Console.WriteLine("The number is odd.");
    }
}
