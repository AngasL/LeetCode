using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedianSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var firstNumsLength = nums1.Length;
            var secondNumsLength = nums2.Length;

            var sortedArray = new int[firstNumsLength + secondNumsLength];

            for (int index = 0; index < firstNumsLength; index++)
            {
                sortedArray[index] = nums1[index];
            }

            for (int index = 0; index < secondNumsLength; index++)
            {
                var flag = firstNumsLength + index - 1;

                while (flag > -1 && sortedArray[flag] > nums2[index])
                {
                    sortedArray[flag + 1] = sortedArray[flag];
                    flag--;
                }
                flag++;
                sortedArray[flag] = nums2[index];
            }

            var isDouble = sortedArray.Length % 2 == 0;
            double result = 0;
            var middle = sortedArray.Length / 2;
            if (isDouble)
            {
                result = (sortedArray[middle] + sortedArray[middle - 1]) / 2.0;
            }
            else
            {
                result = sortedArray[middle];
            }

            return result;
        }

        public double FindMedianSortedArrays_v2(int[] nums1, int[] nums2)
        {
            var l1 = nums1.Length;
            var l2 = nums2.Length;

            var sortedArray = new int[l1 + l2];
            var index = l1 + l2 - 1;
            while (l1 > 0 && l2 > 0)
            {
                if (nums1[l1 - 1] > nums2[l2 - 1])
                {
                    sortedArray[index] = nums1[l1 - 1];
                    l1--;
                }
                else
                {
                    sortedArray[index] = nums2[l2 - 1];
                    l2--;
                }

                index--;
            }
            if (l1 == 0)
            {
                while (l2 > 0)
                {
                    sortedArray[index] = nums2[l2 - 1];
                    l2--;
                    index--;
                }
            }
            else if (l2 == 0)
            {
                while (l1 > 0)
                {
                    sortedArray[index] = nums1[l1 - 1];
                    l1--;
                    index--;
                }
            }

            var isDouble = sortedArray.Length % 2 == 0;
            double result = 0;
            var middle = sortedArray.Length / 2;
            if (isDouble)
            {
                result = (sortedArray[middle] + sortedArray[middle - 1]) / 2.0;
            }
            else
            {
                result = sortedArray[middle];
            }

            return result;
        }
    }
}
