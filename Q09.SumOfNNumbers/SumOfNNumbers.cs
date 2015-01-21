using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        float singleNumber = 0f;
        float sum = 0f;

        for (int i = 0; i < n; i++)
        {
            singleNumber = float.Parse(Console.ReadLine());
            sum += singleNumber;
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}