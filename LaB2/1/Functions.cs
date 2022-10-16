using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Functions
    {
        public static void SortingByMax(int[] arr)
        {
            int value;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        value = arr[i];
                        arr[i] = arr[j];
                        arr[j] = value;
                    }
                }
            }
        }
        public static int FindingMaxInArray(int[] arr)
        {
            int valueMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (valueMax < arr[i])
                {
                    valueMax = arr[i];
                }               
            }
            return valueMax;
        }

        public static int FindingMinInArray(int[] arr)
        {
            int valueMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (valueMin > arr[i])
                {
                    valueMin = arr[i];
                }
            }
            return valueMin;
        }
    }
}
