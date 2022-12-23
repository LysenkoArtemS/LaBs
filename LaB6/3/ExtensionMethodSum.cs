using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    static class ExtensionMethodSum
    {
        public static T Sum<T>(this T[] arr, Func<T, T, T> cmplx)
        {
            T sum = default;
            foreach (var i in arr)
            {
                sum = cmplx(sum, i);
            }
            return sum;
        }
    }
}
