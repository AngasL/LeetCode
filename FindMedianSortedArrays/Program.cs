using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };

            var solution = new Solution();

            Console.WriteLine(solution.FindMedianSortedArrays_v2(nums1, nums2));

            Console.ReadKey();
        }
    }
}
