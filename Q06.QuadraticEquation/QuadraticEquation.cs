using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("ax^2 + bx + c = 0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c; //This is the descriminant
        double x1;
        double x2;
        string output = "";//This will be used to print the answers
        if (d < 0)
        {
            //If the descriminant is negative, there are no real roots
            output = "no real roots";
        }
        else
        {
            if (d == 0) //There is only one root
            {
                x1 = (-b) / (2 * a);
                x2 = x1;
                output = String.Format("x1=x2={0}", x1);
            }
            else //There are two positive roots
            {
                x1 = (-b - Math.Sqrt(d))/ (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                output = String.Format("x1={0}; x2={1}", x1, x2);
            }
        }
        Console.WriteLine(output);
    }
}
