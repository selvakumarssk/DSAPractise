using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSAPractise.LinkedList
{

    /// <summary>
    /// Definition for Doubly-linked list.
    /// </summary>


    public class Solution
    {
        public class DoublyListNode
        {
            public int Capacity { get; set; }
            public int val;
            public DoublyListNode pre;
            public DoublyListNode next;
            public DoublyListNode(int x) { this.val = x; this.next = null; }
        }

        public int Capacity { get; set; }
        public Dictionary<int, DoublyListNode> Hashmap { get; set; }
        public DoublyListNode Head { get; set; }
        public DoublyListNode Tail { get; set; }

        public Solution(int capacity)
        {
            Capacity = capacity;
            Hashmap = new Dictionary<int, DoublyListNode>();
            Head = null;
            Tail = null;
        }

        public int get(int key)
        {
            if (Hashmap.Keys.Contains(key))
            {
                var node = Hashmap[key];
                Hashmap.Remove(key);
                DeleteNode(node);
                Hashmap.Add(key, node);
                if(Head==null)
                {
                    Head = node;
                }
                if (Tail != null)
                {
                    Tail.next = node;
                    node.pre = Tail;
                }
                Tail = node;
                return node.val;
            }
            return -1;
        }

        public void set(int key, int value)
        {
            DoublyListNode node;
            if (Hashmap.Keys.Contains(key))
            {
                node = Hashmap[key];
                node.val = value;
                Hashmap.Remove(key);
                DeleteNode(node);
            }
            else
            {
                if (Hashmap.Count() == Capacity)
                {
                    Hashmap.Remove(Hashmap.Last().Key);
                    DeleteNode(Head);
                }
                node = new DoublyListNode(value);
            }
            Hashmap.Add(key, node);
            if (Head == null)
            {
                Head = node;
            }
            if (Tail != null)
            {
                Tail.next = node;
                node.pre = Tail;
            }
            Tail = node;
        }

        public void DeleteNode(DoublyListNode node)
        {
            if (node.pre == null && node.next == null)
            {
                Head = null;
                Tail = null;
            }
            else if (node.pre == null)
            {
                node.next.pre = null;
                Head = node.next;
            }
            else if (node.next == null)
            {
                node.pre.next = null;
                Tail = node.pre;
            }
            else
            {
                node.pre.next = node.next;
                node.next.pre = node.pre;
            }
        }

    }
   
}
