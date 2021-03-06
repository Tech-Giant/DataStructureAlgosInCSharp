﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sort
{
    public class LargestNumber
    {
        public string largeNumber(List<int> A)
        {
            int[] arr = A.ToArray();
            List<string> newList = new List<string>(Array.ConvertAll(arr, x => x.ToString()));
            newList.Sort(MyCompare);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < newList.Count; i++)
            {
                sb.Append(newList[i]);
            }

            return sb.ToString();
        }

        internal static int MyCompare(string first, string second)
        {
            string firstSecond = first + second;

            string secondFirst = second + first;

            int comparer = firstSecond.CompareTo(secondFirst) > 0 ? -1 : 1;

            return comparer;
        }
    }
}
