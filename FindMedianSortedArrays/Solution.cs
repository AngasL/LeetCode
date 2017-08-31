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
                if (index == 0)
                {
                    sortedArray[0] = nums1[0];
                }
                else
                {
                    var flag = index;

                    while (flag > -1 && sortedArray[flag] > nums1[index])
                    {
                        sortedArray[flag + 1] = sortedArray[flag];
                        flag--;
                    }
                    sortedArray[flag] = nums1[index];
                }
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
    }
}
