using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            var result = 0;
            var array = s.ToCharArray();
            var flag = 0;
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < array.Length;)
            {
                var flagIsUpdated = false;
                for (int j = i; j < array.Length; j++)
                {
                    if (!dic.ContainsKey(array[j]))
                    {
                        dic.Add(array[j], j);
                    }
                    else
                    {
                        flag = dic[array[j]];
                        flagIsUpdated = true;
                        break;
                    }
                }

                result = result > dic.Count() ? result : dic.Count();

                dic.Clear();
                if (!flagIsUpdated)
                {
                    break;
                }

                i = flag + 1;
            }

            return result;
        }
    }
}
