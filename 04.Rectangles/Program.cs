using System;
/*
    Problem 4. Rectangles
    Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */
class Rectagles
{
    static void Main()
    {
        Console.Write("Please enter the width of the rectangle ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter the height of the rectangle ");
        double heigth = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + heigth);
        Console.WriteLine("The perimeter of this rectabgle is {0}", perimeter);
        double area = width * heigth;
        Console.WriteLine("The area of this rectabgle is {0}", area);
    }
}