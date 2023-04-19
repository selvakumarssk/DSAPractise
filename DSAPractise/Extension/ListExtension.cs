using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise.Extension
{
    public static class ListExtension
    {
        public static void SwapItems<T>(this List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[secondIndex] = list[firstIndex];
            list[firstIndex] = temp;
        }

        public static void PrtintAllItems<T>(this List<T> list, string prefixText = null)
        {
            string res = string.Join(", ", list);
            if ((prefixText != null) && (res.Length > 0))

                Console.WriteLine(prefixText + Environment.NewLine + res);
            else
                Console.WriteLine(res);
        }
    }
}
