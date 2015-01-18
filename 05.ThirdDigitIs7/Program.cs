using System;
/*
    Problem 5. Third Digit is 7?
    Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */
class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter an integer number ");
        int number = int.Parse(Console.ReadLine());
        int noLastNumbers = number / 100;
        bool is7 = noLastNumbers % 10 == 7;
        Console.WriteLine("Is the third digit from right-to-left 7? --> {0}", is7);
    }
}
