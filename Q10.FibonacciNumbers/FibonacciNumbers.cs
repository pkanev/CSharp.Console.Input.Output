using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        if (n > 1) //Check if more than 1 term of the sequence are needed
        {
            fibonacci[1] = 1; // set the second term
            for (int i = 0; i < n; i++)
            {
                if (i < 2) //print the first two terms
                {
                    Console.Write("{0} ", fibonacci[i]);
                }
                else //print the remaining terms if there are more than 2 terms
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    Console.Write("{0} ", fibonacci[i]);
                }
            }
        }
        else //prints the first term
        {
            Console.Write("{0} ", fibonacci[0]);
        }
        
    }
}