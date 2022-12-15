using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3;
public class Loop
{

    public static int digital_root(int a)
    {
        int sum = 0;

        while (a > 0 || sum > 9)
        {
            if (a == 0)
            {
                a = sum;
                sum = 0;
            }
            sum += a % 10;
            a /= 10;
        }
        return sum;
    }

    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write(digital_root(a));
    }
}