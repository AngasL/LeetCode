using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var rest = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (rest == nums[j])
                    {
                        return new int[] { nums[i], nums[j] };
                    }
                }
            }

            throw new Exception("not found");
        }
    }
}
