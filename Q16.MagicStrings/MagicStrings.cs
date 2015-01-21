using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        bool no = true;
        for (int i = 4; i < 21; i++)
        {
            int z = i + diff;
            if (z <= 20 && z >= 4)
            {
                List<string> firstValue = getString(i);
                List<string> secondValue = getString(z);
                foreach (string str1 in firstValue)
                {
                    foreach (string str2 in secondValue)
                    {
                        Console.WriteLine(str1 + str2);
                    }
                }
                firstValue = getString(z);
                secondValue = getString(i);
                foreach (string str1 in firstValue)
                {
                    foreach (string str2 in secondValue)
                    {
                        Console.WriteLine(str1 + str2);
                    }
                }
                no = false;
            }
        }
        if (no == true )
        {
            Console.WriteLine("No");
        }
    }
    public static List<string> getString(int sum)
    {
        int lastDigit = 0;
        List<string> letters = new List<string>();
        for (int i = 1; i < 6; i++)
        {
            if (i == 2)
            {
                continue;
            }
            for (int g = 1; g < 6; g++)
            {
                if (g == 2)
                {
                    continue;
                } for (int z = 1; z < 6; z++)
                {
                    if (z == 2)
                    {
                        continue;
                    }
                    lastDigit = sum - i - g - z;
                    if ((lastDigit == 1) || (lastDigit == 3) || (lastDigit == 4) || (lastDigit == 5))
                    {
                        string letter = ""+convertToLetters(i)+convertToLetters(g)+convertToLetters(z)+convertToLetters(lastDigit);
                        letters.Add(letter);
                    }
                }
            }
        }
        return letters;
    }

    public static char convertToLetters (int x)
    {
        char letter = ' ';
        switch (x)
	    {
            case 1: 
                letter = 'k';
                break;
            case 3:
                letter = 's';
                break;
            case 4:
                letter = 'n';
                break;
            case 5:
                letter = 'p';
                break;
		    default:
            break;
	    }
        return letter;
    }
}