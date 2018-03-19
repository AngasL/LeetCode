using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum_BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var rest = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (rest == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new Exception("not found");
        }

        public int[] TwoSum_2PassDisctionary(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dic.ContainsKey(complement) && dic[complement] != i)
                {
                    return new int[] { i, dic[complement] };
                }
            }

            throw new Exception("not found");
        }

        public int[] TwoSum_1PassDisctionary(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }

                dic.Add(nums[i], i);
            }

            throw new Exception("not found");
        }
    }
}
