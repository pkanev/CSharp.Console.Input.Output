using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n/2, g = 1; i >= 0; i--)
        {
            Console.Write(new String('-', i));
            Console.Write(new String('*', g));
            Console.WriteLine(new String('-', i));
            g += 2;

        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(new String('|', 1));
            Console.Write(new String('*', n-2));
            Console.WriteLine(new String('|', 1));
        }
    }
}