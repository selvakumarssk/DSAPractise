using DSAPractise.Extension;
using DSAPractise.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSAPractise.Stacks;

namespace DSAPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList;
            #region Sorting

            //#region Insertion Sort
            //var r = InsertionSort.InsertionSortOnText("11 0 1 2 0");
            //Console.WriteLine("Insertion Sort From Text:" + Environment.NewLine + string.Join(",", r));

            //intList = new List<int>() { 5, 2, 4, 88, 50 };
            //InsertionSort.InsertionSortOnList(intList);
            //intList.PrtintAllItems("Insertion Sort On List:");
            //#endregion

            #endregion

            #region Linked List
            //ListNode A = new ListNode(16);
            //A.next = new ListNode(3); 
            //A.next.next = new ListNode(3);
            //A.next.next.next = new ListNode(6);
            //A.next.next.next.next = new ListNode(7);
            //var result = SinglyLL.DeleteByValue(A, 1);

            //var nodeValues = new List<int>() { 5, 66, 68, 42, 73, 25, 84, 63, 72, 20, 77, 38, 8, 99, 92, 49, 74, 45, 30, 51, 50, 95, 56, 19, 31, 26, 98, 67, 100, 2, 24, 6, 37, 69, 11, 16, 61, 23, 78, 27, 64, 87, 3, 85, 55, 22, 33, 62 };
            //var list = new ListNode(nodeValues[0]);
            //var temp = list;
            //for (int i = 1; i < nodeValues.Count(); i++)
            //{
            //    temp.next = new ListNode(nodeValues[i]);
            //    temp = temp.next;
            //}
            //list = SinglyLL.SortList(list);

            #region LRU cache
            //var ss = "50 6 S 6 13 S 15 15 S 3 6 G 4 S 2 6 S 12 13 S 2 9 S 11 9 S 6 7 G 5 G 13 S 10 4 G 6 G 6 G 8 G 14 G 10 S 5 2 G 9 S 4 1 G 11 G 1 S 4 7 S 11 12 S 12 1 S 10 2 G 3 G 10 S 14 13 S 1 10 G 1 G 9 G 1 G 11 G 13 S 14 15 G 11 S 12 14 S 9 2 G 12 G 3 S 3 12 S 8 7 S 14 11 S 7 13 S 9 4 S 11 11 G 6 G 4 S 5 3";
            //ss = "6 1 S 2 1 S 2 2 G 2 S 1 1 S 4 1 G 2";
            //ss = "32 4 S 5 13 S 9 6 S 4 1 G 4 S 6 1 S 8 11 G 13 G 1 S 12 12 G 10 S 15 13 S 2 13 S 7 5 S 10 3 G 6 G 10 S 15 14 S 5 12 G 5 G 7 G 15 G 5 G 6 G 10 S 7 13 G 14 S 8 9 G 4 S 6 11 G 9 S 6 12 G 3";
            //List<string> query = ss.Split(' ').ToList();

            //var cc = ss.Split(' ').Count(x => x == "S" || x == "G");
            //int count = int.Parse(query[0]);
            //int capacity = int.Parse(query[1]);
            //var solution = new Solution(capacity);
            //int queryCount = 1;
            //int i = 2;
            //while (i < query.Count)
            //{
            //    if (query[i] == "S")
            //    {
            //        solution.set(int.Parse(query[i + 1]), int.Parse(query[i + 2]));
            //        i += 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine(solution.get(int.Parse(query[i + 1])));
            //        i += 2;
            //    }
            //    queryCount++;
            //}

            ////solution.set(2, 1);
            ////solution.set(2, 2);
            ////Console.WriteLine(solution.get(2));
            ////solution.set(1, 1);
            ////solution.set(4, 1);
            ////Console.WriteLine(solution.get(2));
            #endregion
            #endregion

            #region Tree
            //var x = DSAPractise.Tree.Tree.BuildTreeFromInorderAndPreorder(new List<int>() { 1,2,3 }, new List<int>() { 2,1,3 });

            #endregion

            #region Stacks
            var res = Stacks.Stacks.DoubleCharacterTrouble("bcaaaaa");
            #endregion

            Console.ReadLine();
        }


    }
}
