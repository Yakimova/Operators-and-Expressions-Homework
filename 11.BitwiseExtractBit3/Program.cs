using System;
/*
    Problem 11. Bitwise: Extract Bit #3
    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.
 */
class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Please enter the unsigned ineteger: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} --> {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        int mask = 1<<3;
        int result = ((mask & number) >> 3);
        Console.WriteLine("The value of bit #3 of {0} is {1}", number, result);
    }
}
