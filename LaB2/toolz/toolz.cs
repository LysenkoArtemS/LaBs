using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolz
{
    public static class toolz
    {
        public static void Printing1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0};", arr[i]);
            };
        }

        public static void FillingArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 50);
            };
        }
        public static int[] CreatingArray()
        {
            int ammount;
            Console.Write("Введите количество элементов массива: ");
            bool check = int.TryParse(Console.ReadLine(), out ammount);
            if ((ammount <= 0) || (check == false))
            {
                Console.WriteLine("Некорректные данные. Размер заменен на 5");
                ammount = 5;
            }
            int[] changedArr = new int[ammount];
            return changedArr;
        }
        public static void FillingArrayKeyboard(int[] arr)
        {
            Console.WriteLine("Введите элементы массива :");
            for (int i = 0; i < arr.Length; i++)
            {
                bool check1 = int.TryParse(Console.ReadLine(), out arr[i]);
                if (check1 == false)
                {
                    Console.WriteLine(" <- Некорректные данные. " +
                                            "Значение элемента заменено на 0");
                    arr[i] = 0;

                }
            }
        }

    }
}
