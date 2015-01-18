using System;
/*
    Problem 9. Trapezoids
    Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter the first side of the trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second side of the trapezoid: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the height of the trapezoid: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area is: {0}", area);
    }
}
