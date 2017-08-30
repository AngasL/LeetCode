using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "pwwkew";

            var solution = new Solution();

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            var result = solution.LengthOfLongestSubstring(source);

            stopWatch.Stop();

            Console.WriteLine(result);
            Console.WriteLine(stopWatch.Elapsed);
            Console.Read();
        }
    }
}
