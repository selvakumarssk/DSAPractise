using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractise
{
    public static class InsertionSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">Input Example: "11 0 1 2 0"</param>
        /// <returns></returns>
        public static List<int> InsertionSortOnText(string s)
        {
            var res = new List<int>();
            var splittedNumbers = s.Split(' ').Select(x => int.Parse(x)).ToList();
            int n = 0;
            foreach (var number in splittedNumbers)
            {
                res.Add(0);
                int j = n;
                for (; j > 0; j--)
                {
                    if (res[j - 1] > number)
                    {
                        res[j] = res[j - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                res[j] = number;
                n++;
            }
            return res;

        }

        public static void InsertionSortOnList(List<int> a)
        {
            //Get number of elements in the List
            int n = a.Count();
            //Loop all the elements from index 1 to n-1
            for (int i = 1; i < n; i++)
            {
                //Get value of current index from the List
                int number = a[i];
                //initialize j as i-1
                int j = i - 1;
                //loop from i-1 to 0 and check a[j] is less than number(i indexed value from the list)
                for (; j >= 0 && a[j] > number; --j)
                {
                    //right move the j indexed value
                    a[j + 1] = a[j];
                }
                //place the number in j+1 indexed position
                a[j + 1] = number;
            }
        }
    }
}
