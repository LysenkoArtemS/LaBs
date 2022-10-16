using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Functions
    {
        public static int[] RemovingAllNegativeElementsInArray(int[] arr)
        {
            int number = arr.Length - toolz.tools.AmmountOfNegativeEvementsInArray(arr);
            int j = 0;
            int[] freearr = new int[number];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    freearr[j] = arr[i];
                    j++;
                }
            }
            return freearr;
        }
    }
}
