using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 2,3,4};

            var solution = new Solution();

            var result = solution.TwoSum_BruteForce(array, 6);

            Console.ReadKey();
        }
    }
}
