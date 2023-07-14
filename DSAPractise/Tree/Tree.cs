using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise.Tree
{
    public static class Tree
    {
        public static List<int> InorderTraversal(TreeNode A)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var cur = A;

            while (cur != null || stack.Count() > 0)
            {
                if (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                else
                {
                    cur = stack.Pop();
                    result.Add(cur.val);
                    cur = cur.right;
                }
            }
            return result;
        }

        public static List<int> PreorderTraversal(TreeNode A)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var cur = A;

            while (cur != null || stack.Count() > 0)
            {
                if (cur != null)
                {
                    result.Add(cur.val);
                    stack.Push(cur);
                    cur = cur.left;
                }
                else
                {
                    cur = stack.Pop();
                    cur = cur.right;
                }
            }
            return result;
        }

        public static List<int> PostorderTraversal(TreeNode A)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var cur = A;

            while (cur != null || stack.Count() > 0)
            {
                if (cur != null)
                {
                    stack.Push(cur);
                    result.Add(cur.val);
                    cur = cur.right;
                }
                else
                {
                    cur = stack.Pop();
                    cur = cur.left;
                }
            }
            result.Reverse();
            return result;
        }

        /// <summary>
        /// Binary Tree From Inorder And Postorder
        /// </summary>
        /// <param name="A">inorder traversal of a tree,</param>
        /// <param name="B">postorder traversal of a tree,</param>
        /// <returns></returns>
        public static TreeNode BuildTreeFromInorderAndPostorder(List<int> A, List<int> B)
        {
            Dictionary<int, int> dicNode = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                dicNode.Add(A[i], i);
            }
            var root = BuildTreeNodeFromInorderAndPostorder(A, B, dicNode, 0, A.Count - 1, A.Count - 1);
            return root;
        }

        private static TreeNode BuildTreeNodeFromInorderAndPostorder(List<int> A, List<int> B, Dictionary<int, int> dicNode, int st_in, int ed_in, int ed_po)
        {
            //checking start index is greater end index of inorder 
            if (st_in > ed_in) return null;
            //create the node from last value post-order
            var root = new TreeNode(B[ed_po]);
            //Root node's index in inorder traversal
            var node_idx_in = dicNode[root.val];
            //# nodes in right of root node from inorder traversal
            int cnt_R = ed_in - node_idx_in;
            //to find Left node of root 
            root.left = BuildTreeNodeFromInorderAndPostorder(A, B, dicNode,
                                            st_in, //start index of inorder
                                            node_idx_in - 1, //before value index of root value in inorder
                                            ed_po - cnt_R - 1); // end of post-order - no.of node in right-1
            //to find Right node of root 
            root.right = BuildTreeNodeFromInorderAndPostorder(A, B, dicNode,
                                             node_idx_in + 1,//next value index of root value in inorder
                                             ed_in,//end index of inorder
                                             ed_po - 1); //before value index of end index of post-order
            return root;
        }

        /// <summary>
        /// Binary Tree From Preorder and Inorder 
        /// </summary>
        /// <param name="A">Preorder traversal of a tree,</param>
        /// <param name="B">Inorder traversal of a tree,</param>
        /// <returns></returns>
        public static TreeNode BuildTreeFromInorderAndPreorder(List<int> A, List<int> B)
        {
            Dictionary<int, int> dicNode = new Dictionary<int, int>();
            for (int i = 0; i < B.Count; i++)
            {
                dicNode.Add(B[i], i);
            }
            var root = BuildTreeNodeFromInorderAndPreorder(A, B, dicNode, 0, A.Count - 1, 0);
            return root;
        }

        private static TreeNode BuildTreeNodeFromInorderAndPreorder(List<int> A, List<int> B, Dictionary<int, int> dicNode, int st_in, int ed_in, int st_p)
        {
            //checking start index is greater end index of inorder 
            if (st_in > ed_in) return null;
            //create the node from first value pre-order
            var root = new TreeNode(A[st_p]);
            //Root node's index in inorder traversal
            var node_idx_in = dicNode[root.val];
            //# nodes in left of root node from inorder traversal
            int cnt_L = node_idx_in - st_in;
            //# nodes in right of root node from inorder traversal
            int cnt_R = ed_in - node_idx_in;
            //to find Left node of root 
            root.left = BuildTreeNodeFromInorderAndPreorder(A, B, dicNode,
                                            st_in, //start index of inorder
                                            node_idx_in - 1, //before value index of root value in inorder
                                            st_p + 1); // start of preorder + 1
            //to find Right node of root 
            root.right = BuildTreeNodeFromInorderAndPreorder(A, B, dicNode,
                                             node_idx_in + 1,//next value index of root value in inorder
                                             ed_in,//end index of inorder
                                             st_p + cnt_L + 1); //index of root value + count of L + 1
            return root;
        }
    }


    /// <summary>
    /// Definition for binary tree
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }

}
