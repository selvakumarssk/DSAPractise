using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise.Stacks
{
    public static class Stacks
    {
        public static int BalancedParanthesis(string A)
        {
            Stack<char> stack = new Stack<char>();
            //loop all the Paranthesis
            foreach (char c in A)
            {
                //if open Paranthesis add to stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                //Paranthesis is not open and stack count is 0
                //means for current Paranthesis there is not open Paranthesis, so not balanced
                else if (stack.Count == 0)
                {
                    return 0;
                }
                else
                {
                    //checking for current close Paranthesis, the previous Paranthesis is not matched open Paranthesis
                    if (c == ')' && stack.Pop() != '(')
                    {
                        return 0;
                    }
                    //checking for current close Paranthesis, the previous Paranthesis is not matched open Paranthesis
                    else if (c == '}' && stack.Pop() != '{')
                    {
                        return 0;
                    }
                    //checking for current close Paranthesis, the previous Paranthesis is not matched open Paranthesis
                    else if (c == ']' && stack.Pop() != '[')
                    {
                        return 0;
                    }
                }
            }
            //stack count should be 0 because every open Paranthesis should be matched by close Paranthesis
            return stack.Count == 0 ? 1 : 0;
        }

        public static string DoubleCharacterTrouble(string A)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(A[0]);
            for (int i = 1; i < A.Length; i++)
            {
                if (stack.Count == 0 || A[i] != stack.Peek())
                {
                    stack.Push(A[i]);
                }
                else
                {
                    stack.Pop();
                }
            }
            StringBuilder result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }
            return string.Join("", result.ToString().Reverse());
        }

        public static int EvaluateExpression(List<string> A)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var a in A)
            {
                if (a == "+")
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();
                    stack.Push(v1 + v2);
                }
                else if (a == "-")
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();
                    stack.Push(v1 - v2);
                }
                else if (a == "*")
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();
                    stack.Push(v1 * v2);
                }
                else if (a == "/")
                {
                    int v2 = stack.Pop();
                    int v1 = stack.Pop();
                    stack.Push(v1 / v2);
                }
                else
                {
                    stack.Push(int.Parse(a));
                }
            }
            return stack.Pop();
        }

        public static int PassingGame(int A, int B, List<int> C)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(B);
            foreach (int c in C)
            {
                if (c == 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Pop();
        }

        public static List<int> NearestSmallerElement(List<int> A)
        {
            List<int> ans = new List<int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count != 0 && stack.Peek() >= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    ans.Add(-1);
                }
                else
                {
                    ans.Add(stack.Peek());
                }
                stack.Push(A[i]);

            }

            return ans;
        }
    }
}
