using System;
/*
    Problem 6. Four-Digit Number
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

    The number has always exactly 4 digits and cannot start with 0.
 */
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number, which doesn't start with 0: ");
        int number = int.Parse(Console.ReadLine());

        // first, getting the digits
        int firstDigit = (number / 1000);
        int secondDigit = ((number - 1000 * firstDigit) / 100);
        int thirdDigit = ((number - 1000 * firstDigit - 100 * secondDigit) / 10);
        int fourthDigit = (number % 10);

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("The sum of the digits of {0} is {1} ", number, sumOfDigits);

        int reversedNumber = (1000 * fourthDigit) + (100 * thirdDigit) + (10 * secondDigit) + firstDigit;
        Console.WriteLine("The reversed number for {0} is {1} ", number, reversedNumber);

        int lastDigitInfront = (1000 * fourthDigit) + (number / 10);
        Console.WriteLine("When the last digit is infront the number {0} looks like this: {1}", number, lastDigitInfront);

        int secondAndThirdExchanged = (1000 * firstDigit) + (100 * thirdDigit) + (10 * secondDigit) + fourthDigit;
        Console.WriteLine("When the second and the third digit are exchanged the number {0} looks like this: {1} ", number, secondAndThirdExchanged);
    }
}
