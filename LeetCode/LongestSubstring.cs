using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            /* head consumes until dupe, tail then spits out til no more dupes
             * "vmkvstdnpgcygdgvfgrz"
             * <---*________*------->
             * <----------*_*------->
             */
            int longest = 0;
            int maxIndex = s.Length;
            int tailIndex = 0;
            int headIndex = 0;

            var sb = new StringBuilder();
            var map = new HashSet<char>();
            while (headIndex < maxIndex)
            {
                
                // Move head upward until dupe
                while (headIndex < maxIndex && !map.Contains(s[headIndex]) )
                {
                    sb.Append(s[headIndex]);
                    map.Add(s[headIndex]);

                    headIndex++;
                }
                
                if (sb.Length > longest)
                {
                    longest = sb.Length;
                }

                while (headIndex < maxIndex && map.Contains(s[headIndex]))
                {
                    // move the tail up until no more dupes
                    map.Remove(s[tailIndex]);
                    sb.Remove(0, 1);
                    tailIndex++;
                }
            }

            return longest;
        }
    }
}
