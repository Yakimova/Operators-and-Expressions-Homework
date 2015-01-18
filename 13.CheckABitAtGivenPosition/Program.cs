using System;
/*
    Problem 13. Check a Bit at Given Position 
    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
 */
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter the ineteger: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the index of a bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} --> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        int mask = 1 << p;
        bool value = (((mask & n) >> p) == 1);
        Console.WriteLine("The bit in position {0} in number {1} is 1 --> {2}", p, n, value);
    }
}
