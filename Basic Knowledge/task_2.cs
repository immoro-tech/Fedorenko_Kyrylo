using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_2;

public class Loop
{

    public static char FirstNonRepeat(string str)    
    {
        for(int i = 0; i < str.Length; i++)
        {
           
            bool result = LSA(str[i], str.Substring(i + 1));    
            char c = str[i];
            if(result == false)
            {
                return c;
            }

            
        }
        

       return(' ');
    }


   
    public static bool LSA(char c, string s)    
    {
        s = s.ToLower();
        for(int i = 0; i < s.Length;i++)
        {
            if (c == s[i])
            {
                return true;
            }
            
        }
        return false;
    }



    public static void Main()
    {
        string str = Console.ReadLine();
        char s = FirstNonRepeat(str);
        Console.WriteLine(s);
        
    }
}