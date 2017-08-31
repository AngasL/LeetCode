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
            var nums1 = new int[] { };
            var nums2 = new int[] { 2,3 };

            var solution = new Solution();

            Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2));

            Console.ReadKey();
        }
    }
}
