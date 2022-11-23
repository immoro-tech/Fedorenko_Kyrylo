using System;

public static class Loop
{

    public static void FirstNonRepeat(string str)
    {

        for (int i = 0; i < str.Length; i++)
        {

            if (str.IndexOf(str[i], str.IndexOf(str[i]) + 1) == -1)
            {
                Console.Write(
                    "First non-repeating character is "
                    + str[i]);

                break;
            }
                 
        }

        return;
    }

    internal static void Main()
    {
        string str = Console.ReadLine();
         str = str.ToLower();
        FirstNonRepeat(str);
    }
}