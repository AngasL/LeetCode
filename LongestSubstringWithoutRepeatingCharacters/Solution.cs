using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var stringLength = s.Length;
            var array = s.ToCharArray();
            var flag = 1;
            var charList = new List<char>();

            for (int i = 0; i < array.Length; i++)
            {
                if (charList.Count == 0)
                {
                    charList.Add(array[i]);
                }

                for (int j = flag; j < array.Length; j++)
                {
                    if (!charList.Contains(array[j]))
                    {
                        charList.Add(array[j]);
                    }
                    else
                    {
                        flag = j;
                        break;
                    }
                }

                result = result > charList.Count() ? result : charList.Count();
                charList.Remove(array[i]);
            }

            return result;
        }
    }
}
