using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_2
{
    internal class Evennumbercode
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] boo = new int[] { 0, 1, 2, 3, 4 };
            int m = 100;
            int[] scar = new int[100];
            for (int i = 0; i < m; i++)
            {
                scar[i] = i;
            }
            Console.WriteLine($"The total number of even numbers in boo are: {countEvenNum(boo, n)}");
            Console.WriteLine($"The total number of even numbers in scar are: {countEvenNum(scar, m)}");
        }

        public static int countEvenNum(int[] arr, int size)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}


