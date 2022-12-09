using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_6
{
   public class Pool
   {
        public static int Condition(int num)
        {
            num = Math.Abs(num);
            if(num >= 10)
            
                return Condition(num /10) + 1;
                return 1;
            
            
        }


        public static int NextPermutation(int num)
        {
            int n = Condition(num);
            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[n - 1 - i] = num % 10;
                num /= 10;
            }



            if (n == 1)
            {
                return -1;
            }


            int j = 0;
            for (j = n - 1; j > 0; j--)
            {


                if (arr[j] > arr[j - 1])

                    break;

            }



            if (j != 0)
            {



                for (int i = n - 1; i >= j; i--)
                {



                    if (arr[j - 1] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j - 1];
                        arr[j - 1] = temp;
                        break;
                    }
                }
            }




            else if (j == 0)
            {
                return -1;
            }


            int[] res = new int[arr.Length];
            int w = arr.Length - 1;





            for (int i = 0; i < j; i++)
            {
                res[i] = arr[i];
            }





            for (int i = j; i < res.Length; i++)
            {
                res[i] = arr[w--];
            }




            string str = string.Join("", res);
            return Convert.ToInt32(str);
        }

        public static void Main()
        {
            return;
        }

   }

}