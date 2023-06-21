using DSAPractise.Extension;
using DSAPractise.LinkedList;
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
            //List<int> intList;
            //#region Sorting

            //#region Insertion Sort
            //var r = InsertionSort.InsertionSortOnText("11 0 1 2 0");
            //Console.WriteLine("Insertion Sort From Text:" + Environment.NewLine + string.Join(",", r));

            //intList = new List<int>() { 5, 2, 4, 88, 50 };
            //InsertionSort.InsertionSortOnList(intList);
            //intList.PrtintAllItems("Insertion Sort On List:");
            //#endregion

            //#endregion

            #region Linked List
            ListNode A = new ListNode(16);
            A.next = new ListNode(3);
            A.next.next = new ListNode(3);
            A.next.next.next = new ListNode(6);
            A.next.next.next.next = new ListNode(7);
            var result = SinglyLL.Delete(A, 1);


            #endregion
            Console.ReadLine();
        }
    }
}
