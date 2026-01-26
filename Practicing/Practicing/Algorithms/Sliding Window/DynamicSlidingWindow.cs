using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.Algorithhms.Sliding_Window
{
    public static class DynamicSlidingWindow
    {
        public static int LengthLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            for(int right = 0; right < n; right++)
            {
                char currentChar = s[right];

                if (charIndexMap.ContainsKey(currentChar))
                {
                    left = Math.Max(left, charIndexMap[currentChar] + 1);   
                }

                charIndexMap[currentChar] = right;

                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
    }
}
