using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            
            bool TestFunc(int s, int b)
            {
                if (s != b) return true;
                return false;
            }

            var arr = new DynamicArray<int>(1);
            arr.Notify += (sender, e) => { Console.WriteLine($"old {e.OldCapacity} new {e.NewCapacity}"); };
            
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Insert(4, -1);
            arr.Remove(2);
            arr.PrintArr();          
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            DynamicArray<int> arr1 = arr;
            if (arr1.Equals(arr)) { Console.WriteLine(" равны"); }
            arr1.PrintArr();
            arr1.AddRange(arr);
            
           // arr1.Remove(1, TestFunc);
            arr1.PrintArr();
           // arr1.Insert(55, 3);
           Console.ReadKey();
        }       
    }
}
