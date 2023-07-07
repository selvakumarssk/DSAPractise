using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise.LinkedList
{
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
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

        /// <summary>
        /// Using slow Fast pointer approach, middle node is found
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static ListNode GetMiddleNode(ListNode A)
        {
            //List has only two nodes
            if (A != null && A.next != null && A.next.next == null)
            {
                //return the first node as middle 
                return A;
            }

            //Slow pointer
            ListNode sp = A;
            //Fast Pointer
            ListNode fp = A;
            //check fast pointer or next node of fp is null
            while (fp != null && fp.next != null)
            {
                //sp increament by one node
                sp = sp.next;
                //fp increament by 2 node
                fp = fp.next.next;
            }
            //return middle node
            return sp;
        }

        /// <summary>
        /// Merge Two Sorted Lists
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists(ListNode A, ListNode B)
        {
            //check if A list is null
            if (A == null)
            {
                //return B list
                return B;
            }
            //check if B list is null
            if (B == null)
            {
                //return A
                return A;
            }
            //Head node of the merged list
            ListNode Head;
            //Check if A node is the head of merged list by comparing with B
            if (A.val <= B.val)
            {
                //Make A as head of merged list
                Head = A;
                //move to next node
                A = A.next;
            }
            else
            {
                //Make B as head of merged list
                Head = B;
                //move to next node
                B = B.next;
            }
            //copy head node of merged list
            ListNode cur = Head;
            //loop until A and B has values
            while (A != null && B != null)
            {
                //A is less than equal to B
                if (A.val <= B.val)
                {
                    //make A as next of cur
                    cur.next = A;
                    //move to next node
                    A = A.next;
                }
                //Value of B is less than A
                else
                {
                    //make B as next of cur
                    cur.next = B;
                    //move to next node
                    B = B.next;
                }
                //move to next node
                cur = cur.next;
            }
            //all nodes of List A is processed
            if (A == null)
            {
                //make B as next of cur
                cur.next = B;
            }
            //all nodes of List B is processed
            else
            {
                //make A as next of cur
                cur.next = A;
            }
            //return Head node of merged list
            return Head;
        }

        /// <summary>
        /// Sort a linked list
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static ListNode SortList(ListNode A)
        {
            //check list is empty or has one node
            if (A == null || A.next == null)
            {
                //return list
                return A;
            }
            //find the middle node
            var middle = GetMiddleNode(A);
            //copy the starting node of the given list to first half list
            var FHL = A;
            //copy the next node of the middle node second half list
            var SHL = middle.next;
            //remove the next node from middle node to create two half list
            middle.next = null;
            //sort the first half
            FHL = SortList(FHL);
            //sort the second half
            SHL = SortList(SHL);
            //merge the first and second half
            return MergeTwoLists(FHL, SHL);
        }

        /// <summary>
        /// Check Given Linked List has cycle
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool Hascycle(ListNode A)
        {
            //Copy the Head Noe to Slow Pointer
            ListNode sP = A;
            //Copy the Head Noe to Fast Pointer
            var fP = A;
            //slow-fast pointer loop
            while (fP != null && fP.next != null)
            {
                // move the SP by one node
                sP = sP.next;
                // move the FP by two node
                fP = fP.next.next;
                //check SP and FP pointing to same node
                if (sP == fP)
                {
                    //cycle exists 
                    return true;
                }

            }
            //cycle does not exists 
            return false;
        }

        /// <summary>
        /// Get Head Node of the Linked List cycle
        /// </summary>
        /// <param name="A"></param>
        /// <returns>Head Node of the Linked List cycle</returns>
        public static ListNode GetHeadNodeOfTheCycle(ListNode A)
        {
            #region Find meeting point of SP and FP
            ListNode sP = A;
            ListNode fP = A;
            while (fP != null && fP.next != null)
            {
                // move the SP by one node
                sP = sP.next;
                // move the FP by two node
                fP = fP.next.next;
                //check SP and FP pointing to same node
                if (sP == fP)
                {
                    //found the meeting node, break the loop
                    break;
                }
            }
            #endregion

            //Head Node of Cycle
            ListNode hNCycle = A;
            while (hNCycle != sP)
            {
                hNCycle = hNCycle.next;
                sP = sP.next;
            }
            return hNCycle;
        }

        /// <summary>
        /// Break the cycle in the Linked List
        /// </summary>
        /// <param name="A"></param>
        /// <returns>Head Node of the Given Linked List after cycle break</returns>
        public static ListNode Breakcycle(ListNode A)
        {
            #region Find meeting point of SP and FP
            ListNode sP = A;
            ListNode fP = A;
            while (fP != null && fP.next != null)
            {
                // move the SP by one node
                sP = sP.next;
                // move the FP by two node
                fP = fP.next.next;
                //check SP and FP pointing to same node
                if (sP == fP)
                {
                    //found the meeting node, break the loop
                    break;
                }
            }
            #endregion

            //Head Node of Cycle
            ListNode hNCycle = A;
            //Last Node of the cycle
            ListNode lNCycle = A;
            while (hNCycle != sP)
            {
                lNCycle = sP;
                hNCycle = hNCycle.next;
                sP = sP.next;
            }
            lNCycle.next = null;
            return A;
        }
    }
}
