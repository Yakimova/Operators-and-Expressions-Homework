using System;
/*
    Problem 16.** Bit Exchange (Advanced)
    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap.
 */
class BitExchange
{
    static void Main()
    {
        Console.Write("Please enter an unsigned integer number: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Please enter where the first sequence of bits starts - p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter where the second sequence of bits starts - q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of bits to be exchanged - k: ");
        int k = int.Parse(Console.ReadLine());

        if ((p + k) > 32 || (q + k) > 32 || p < 0 || q < 0)
            Console.WriteLine("Out of range.");
        else if (((p < q) && (p + k) > q) || ((q < p) && (q + k) > p))
            Console.WriteLine("The sequences will overlap.");

        else
        {
            Console.WriteLine("Integer number: {0} --> {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
            for (int i = 0; i < k; i++)
            {
                long mask = 1 << (p + i);
                long bitp = (n & mask) >> (p + i);
                mask = 1 << (q + i);
                long bitq = (n & mask) >> (q + i);
                if (bitp == 1)
                    n = n | mask;
                if (bitp == 0)
                    n = n & (~mask);
                mask = 1 << (p + i);
                if (bitq == 1)
                    n = n | mask;
                if (bitq == 0)
                    n = n & (~mask);
            }
            Console.WriteLine("Binery result: {0} --> {1}", Convert.ToString(n, 2).PadLeft(32, '0'), n);
        }
    }
}