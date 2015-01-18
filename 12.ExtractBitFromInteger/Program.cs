using System;
/*
    Problem 12. Extract Bit from Integer
    Write an expression that extracts from given integer n the value of given bit at index p.
 */
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Please enter the ineteger: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the index of a bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} --> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        int mask = 1 << p;
        int result = (mask & n) >> p;
        Console.WriteLine("The bit in position {0} in number {1} is {2}", p, n, result);
    }
}