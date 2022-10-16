using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolz
{
    public static class tools
    {
        public const int arraySize = 12;
        public static void PrintingArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0};", arr[i]);
            };
        }


        public static void FillingArray(int[] arr,int randomBegins,int randomEnds)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(randomBegins, randomEnds);
            };
        }
        public static int[] CreatingArray()
        {
            int ammount;
            Console.Write("Введите количество элементов массива: ");
            bool check = int.TryParse(Console.ReadLine(), out ammount);
            while ((ammount <= 0) || (!check))
            {
                Console.WriteLine("Ошибка. Введите значение повторно");
                check = int.TryParse(Console.ReadLine(), out ammount);
            }
            int[] changedArr = new int[ammount];
            return changedArr;
        }
        public static void FillingArrayKeyboard(int[] arr)
        {
            Console.WriteLine("Введите элементы массива :");
            for (int i = 0; i < arr.Length; i++)
            {
                bool check = int.TryParse(Console.ReadLine(), out arr[i]);
                while (!check)
                {
                    Console.WriteLine("Ошибка. Введите элемент повторно");
                    check = int.TryParse(Console.ReadLine(), out arr[i]);
                }
            }
        }

        public static int AmmountOfNegativeEvementsInArray(int[] arr)
        {
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    number++;
                }
            }
            return (number);
        }
    }

}