using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Functions
    {
        public static bool CheckingArraysSame(int[] arr1, int[] arr2)
        {
            bool same = true;
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                if ((arr1[i]) != (arr2[i]))
                {
                    same = false;
                    break;
                }
            }
            return same;
        }
    }
}
