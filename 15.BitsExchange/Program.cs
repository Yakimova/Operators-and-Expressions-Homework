using System;
/*
    Problem 15.* Bits Exchange
    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */
class BitsExchange
{
    static void Main()
    {
        Console.Write("Please enter an unsigned integer number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Integer number: {0} --> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        // first, getting the values of the 6 bits
        uint mask = 1 << 3;
        uint bit3 = (mask & n) >> 3;
        mask = 1 << 4;
        uint bit4 = (mask & n) >> 4;
        mask = 1 << 5;
        uint bit5 = (mask & n) >> 5;
        mask = 1 << 24;
        uint bit24 = (mask & n) >> 24;
        mask = 1 << 25;
        uint bit25 = (mask & n) >> 25;
        mask = 1 << 26;
        uint bit26 = (mask & n) >> 26;

        // and now changing the values
        mask = 1 << 3;
        if (bit24 == 1)
            n = n | mask;
        if (bit24 == 0)
            n = n & (~mask);

        mask = 1 << 4;
        if (bit25 == 1)
            n = n | mask;
        if (bit25 == 0)
            n = n & (~mask);

        mask = 1 << 5;
        if (bit26 == 1)
            n = n | mask;
        if (bit26 == 0)
            n = n & (~mask);

        mask = 1 << 24;
        if (bit3 == 1)
            n = n | mask;
        if (bit3 == 0)
            n = n & (~mask);

        mask = 1 << 25;
        if (bit4 == 1)
            n = n | mask;
        if (bit4 == 0)
            n = n & (~mask);

        mask = 1 << 26;
        if (bit5 == 1)
            n = n | mask;
        if (bit5 == 0)
            n = n & (~mask);

        Console.WriteLine("Binery result: {0} --> {1}", Convert.ToString(n, 2).PadLeft(32, '0'), n);
    }
}