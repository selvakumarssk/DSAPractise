using DSAPractise.Extension;
using DSAPractise.LinkedList;
using System;
using System.Collections;
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
            //ListNode A = new ListNode(16);
            //A.next = new ListNode(3); 
            //A.next.next = new ListNode(3);
            //A.next.next.next = new ListNode(6);
            //A.next.next.next.next = new ListNode(7);
            //var result = SinglyLL.DeleteByValue(A, 1);

            var nodeValues = new List<int>() { 5, 66, 68, 42, 73, 25, 84, 63, 72, 20, 77, 38, 8, 99, 92, 49, 74, 45, 30, 51, 50, 95, 56, 19, 31, 26, 98, 67, 100, 2, 24, 6, 37, 69, 11, 16, 61, 23, 78, 27, 64, 87, 3, 85, 55, 22, 33, 62 };
            var list = new ListNode(nodeValues[0]);
            var temp = list;
            for (int i = 1; i < nodeValues.Count(); i++)
            {
                temp.next = new ListNode(nodeValues[i]);
                temp = temp.next;
            }
            list = SinglyLL.SortList(list);
            #endregion
            Console.ReadLine();
        }
    }
}
