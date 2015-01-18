using System;
/*
    Problem 7. Point in a Circle
    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */
class PointInACircle
{
    static void Main()
    {
        Console.Write("Please enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y: ");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Sqrt((x * x) + (y * y));
        Console.WriteLine(z<=2? "The point is inside.": "The point is not inside.");
    }
}