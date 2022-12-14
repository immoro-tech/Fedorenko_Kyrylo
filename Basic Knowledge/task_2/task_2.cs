using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2;


public class Loop
{
    public static char? FirstNonRepeat(string str)
    {
        Dictionary<char, int> countChars = new Dictionary<char, int>();
        foreach (char symbol in str)
        {
            if (countChars.ContainsKey(char.ToLower(symbol)))
            {
                countChars[char.ToLower(symbol)]++;
            }
            else if (countChars.ContainsKey(char.ToUpper(symbol)))
            {
                countChars[char.ToUpper(symbol)]++;
            }
            else
            {
                countChars.Add(symbol, 1);
            }
        }
        foreach (char symbol in str)
        {
            if (countChars[symbol] == 1)
            {
                return symbol;
            }
        }
        return ' ';

    }

    static void Main()
    {
        Loop loop = new Loop();
        string str = "sTreSS";
        FirstNonRepeat(str);
        Console.WriteLine(FirstNonRepeat(str));
    }

}

       