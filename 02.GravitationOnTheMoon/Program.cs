using System;
/*
    Problem 2. Gravitation on the Moon
    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */
class GravitationOnTeMoon
{
    static void Main()
    {
        Console.Write("PLease enter your earth weight ");
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = (earthWeight * 17) / 100;
        Console.WriteLine("The weight on the Moon is {0}", moonWeight);
    }
}
