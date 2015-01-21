using System;

class NumbersInIntervalDividableByFive
{
    static void Main()
    {
        Console.Write("start = ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("end = ");
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        //Check the numbers from start to end - 1, use <= to include the last number
        for (int i = 0; i <= (end - start); i++)
        {
            if ((start + i) % 5 == 0)
            {
                ++p;
            }
        }
        Console.WriteLine("p = {0}", p);
    }
}