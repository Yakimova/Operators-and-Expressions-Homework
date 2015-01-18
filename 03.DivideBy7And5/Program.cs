using System;
/*
    Problem 3. Divide by 7 and 5
    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please enter an integer number ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Can the number be divided by 7 and 5? --> " + ((number % 5 == 0) && (number % 7 == 0)));
    }
}