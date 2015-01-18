using System;
/*
    Problem 14. Modify a Bit at Given Position
    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Integer number: {0} --> {1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));

        if (v == 1)
        {
            int mask = 1 << p;
            int newNumber = n | mask;
            Console.WriteLine("Binery result: {0} --> {1}", Convert.ToString(newNumber, 2).PadLeft(16, '0'), newNumber);
        }

        if (v == 0)
        {
            int mask = 1 << p;
            int newNumber = n & (~mask);
            Console.WriteLine("Binery result: {0} --> {1}", Convert.ToString(newNumber, 2).PadLeft(16, '0'), newNumber);
        }
    }
}
