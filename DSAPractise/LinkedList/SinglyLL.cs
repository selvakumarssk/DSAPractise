using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise.LinkedList
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }

    public static class SinglyLL
    {
        /// <summary>
        /// Insert in Linked List.
        /// Return the head of the linked list
        /// </summary>
        /// <param name="A">A is the head of a linked list</param>
        /// <param name="B">B is an integer which denotes the value of the new node</param>
        /// <param name="C">C is an integer which denotes the position of the new node</param>
        /// <returns></returns>
        public static ListNode Insert(ListNode A, int B, int C)
        {
            //Creat new node
            ListNode xn = new ListNode(B);
            //If given List is null, return created node
            if (A == null)
            {
                return xn;
            }
            //insert the node at first inddeex of the list
            if (B == 0)
            {
                //new node's next node is Head node of the given list
                xn.next = A;
                //return node node
                return xn;
            }
            //Previous node of the new node
            //copy the head node
            var previous = A;
            //get the previous node from the given index
            //if given index is greater than no.of nodes in the List, get the last node 
            for (int i = 1; i < C && previous.next != null; i++)
            {
                previous = previous.next;
            }
            //copy the next node of the previous node from the given index
            xn.next = previous.next;
            //make new node as next of the previous node
            previous.next = xn;
            return A;
        }

        /// <summary>
        /// Delete node by value.
        /// </summary>
        /// <param name="A">A is the head of a linked list.</param>
        /// <param name="B">B is the value to be deleted</param>
        /// <returns></returns>
        public static ListNode DeleteByValue(ListNode A, int B)
        {
            //Given list is null
            if (A == null)
            {
                return null;
            }
            //Head node has the value
            if (A.val == B)
            {
                return A.next;
            }
            //Copy the head node
            var curr = A;
            //loop all the nodes if node has next node
            while (curr.next != null)
            {
                //Check the next node's value is equal to given value
                if (curr.next.val == B)
                {
                    //replace the next of current to next node's next 
                    curr.next = curr.next.next;
                    //break the loop
                    break;
                }
                //move to next node
                curr = curr.next;
            }
            //return the head node
            return A;
        }

        /// <summary>
        /// Delete node by position. 0 based Index.
        /// </summary>
        /// <param name="A">A is the head of a linked list.</param>
        /// <param name="B">Position of the node</param>
        /// <returns></returns>
        public static ListNode DeleteByPosition(ListNode A, int B)
        {
            //Given List is null
            if (A == null)
            {
                return null;
            }
            //Delete head node of the list
            if (B == 0)
            {
                return A.next;
            }
            //Copy the Head node
            var pre = A;
            //Get the previous node of given index
            //if given index is greater than no.of nodes in the List, get the last node 
            for (int i = 1; i < B && pre != null; i++)
            {
                pre = pre.next;
            }
            //check node exist at given index
            if (pre.next != null)
            {
                //remove the node at the index from the list
                pre.next = pre.next.next;
            }
            //return head node of the list
            return A;

        }

        /// <summary>
        /// Reverse Linked List
        /// </summary>
        /// <param name="A">Linked-list node</param>
        /// <returns>Head of the Reversed linked-list node</returns>
        public static ListNode ReverseList(ListNode A)
        {
            //if A is null or List has one node
            if (A == null || A.next == null)
            {
                return A;
            }

            ListNode pre = null, cur = A;
            while (cur != null)
            {
                //Get the next node
                ListNode next = cur.next;
                //Replace the next node with previous node for reversing the flow
                cur.next = pre;
                //update the previous node with current node
                pre = cur;
                //update the current node with next node
                cur = next;
            }
            A = pre;
            return A;
        }

        /// <summary>
        /// Check given LLinked List is Palindrome
        /// </summary>
        /// <param name="A">Head of the Linked-list node</param>
        /// <returns></returns>
        public static int PalindromeList(ListNode A)
        {
            //Check List is null or has one node then true
            if (A == null || A.next == null)
            {
                return 1;
            }
            //No.of nodes in the Linked List
            int count = 0;
            var temp = A;
            //count the no.of nodes
            while (temp != null)
            {
                ++count;
                temp = temp.next;
            }
            //find the starting node index of second half of the list by 0 based index
            int startOfSecondHalf = (count % 2 == 0) ? count / 2 : (count / 2) + 1;

            //First node of second half of the list
            ListNode second = A;
            //find the starting node of second half list
            for (int i = 1; i < startOfSecondHalf; i++)
            {
                second = second.next;
            }
            //reverse the second half of the list
            second = ReverseList(second);
            //First node of first half of the list
            ListNode first = A;
            //Compare first and second half of the list
            for (int i = 1; i <= count / 2; i++)
            {
                //values are not same return 0 (not palindrome)
                if (first.val != second.val)
                {
                    return 0;
                }
                //move to the next node of first half
                first = first.next;
                //move to the next node of second half
                second = second.next;
            }
            return 1;
        }
    }
}
