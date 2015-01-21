using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(' ');
        float sum = 0f;
        //The for loop makes this code work with any amount of number
        for (int i = 0; i < separateNumbers.Length; i++)
        {
            sum += float.Parse(separateNumbers[i]);
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
