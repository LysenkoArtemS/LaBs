using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Functions
    {
        public static int SumOfPositiveNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;

        }
    }
}
