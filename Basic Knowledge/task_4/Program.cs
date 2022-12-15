using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4;

 public class Loop
{
    public static int GetPairsCount(int[] arr, int sum)
    {

        int count = 0;

        for (int i = 0; i < arr.Length; i++)

            for (int j = i + 1; j < arr.Length; j++)

                if ((arr[i] + arr[j]) == sum)
                    count++;

        Console.WriteLine("Count of pairs is " + count);
        return count;
    }

    static public void Main()
    {

        Console.Write("Entry number of array elements:\t");
        
        int elements = int.Parse(Console.ReadLine());
        int[] arr = new int[elements];
        
        for (int i =0; i < arr.Length; i++)
        {
            Console.WriteLine($"\nEntry array element at index {i}:\t");
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Entry sum; ");
        int sum = Convert.ToInt32(Console.ReadLine());
        
        GetPairsCount(arr, sum);
    }
}