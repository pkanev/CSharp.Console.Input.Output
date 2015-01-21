using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Greater: {0}", (a > b) ? a : b);
    }
}

