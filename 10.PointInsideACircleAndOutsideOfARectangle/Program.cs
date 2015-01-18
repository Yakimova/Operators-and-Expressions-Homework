using System;
/*
    Problem 10. Point Inside a Circle & Outside of a Rectangle
    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */
class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Please enter x of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y of the point: ");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));
        bool insideCircle = (z <= 1.5);

        bool insideRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        
        bool insideKandOutsideR = insideCircle && (!insideRectangle);
        Console.Write("is the point within the circle and of the rectabgle? --> ");
        Console.WriteLine(insideKandOutsideR ? "Yes." : "No.");
    }
}