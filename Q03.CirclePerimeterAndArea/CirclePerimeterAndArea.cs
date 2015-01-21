using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r = ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("| Radius | Perimeter | Area     |");
        Console.WriteLine(String.Format("| {0,6:F2} | {1,9:F2} | {2,8:F2} |", r, 2*r*Math.PI, r*r*Math.PI));
    }
}