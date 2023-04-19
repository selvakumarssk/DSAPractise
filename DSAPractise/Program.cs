using DSAPractise.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList;
            #region Sorting

            #region Insertion Sort
            var r = InsertionSort.InsertionSortOnText("11 0 1 2 0");
            Console.WriteLine("Insertion Sort From Text:" + Environment.NewLine + string.Join(",", r));

            intList = new List<int>() { 5, 2, 4, 88, 50 };
            InsertionSort.InsertionSortOnList(intList);
            intList.PrtintAllItems("Insertion Sort On List:");
            #endregion

            #endregion
            Console.ReadLine();
        }
    }
}
