using System;
/*
    Problem 8. Prime Number Check
    Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 */
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter the positive integer number: ");
        int number = int.Parse(Console.ReadLine());

        // in mathematics negative numbers cannot be prime
        if (number < 0)
            Console.WriteLine("The negative numbers cannot be prime.");

        // 0 and 1 are not prime by definition
        if (number == 1 || number == 0)
            Console.WriteLine("The number is not prime.");

        // all other integer numbers can be prime if they cannot be devided by any other number, which is smaller than them and is not 1
        if (number > 1)
        {
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    prime = false;
            }
            Console.WriteLine(prime ? "The number {0} is prime." : "The number {0} is not prime.", number);
        }
    }
}
