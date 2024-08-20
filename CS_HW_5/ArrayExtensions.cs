using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_5
{
 public static class ArrayExtensions
    {
        public static double Average(this int[] array)
        {
            if (array == null || array.Length == 0)
                throw new InvalidOperationException("Empty array");
            return System.Linq.Enumerable.Average(array);
        }
    }
}
