using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LongestPalindrome("abccccdd"));
        }
        // 使用消消乐的方法的AC，但是内存消耗过大
        public static int LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }
            // 消消乐
            int length = 0;
            List<int> excludeArray = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                bool existI = excludeArray.Contains(i);
                if (existI) continue;
                for (int j = i + 1; j < s.Length; j++)
                {
                    bool existJ = excludeArray.Contains(j);
                    if (existJ) continue;
                    if (s[i] == s[j])
                    {
                        length += 2;
                        excludeArray.Add(i);
                        excludeArray.Add(j);
                        break;
                    }
                }
            }
            if (excludeArray.Count != s.Length)
            {
                length++;
            }
            return length;
        }
        // 官方解法，字典解法
        public static int LongestPalindromeByDis(string s)
        {
            int ans = 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!charMap.ContainsKey(c))
                {
                    charMap.Add(c, 1);
                }
                else
                {
                    charMap[c]++;
                }
            }
            foreach (KeyValuePair<char, int> kvp in charMap)
            {
                ans += (kvp.Value / 2) * 2;
                // 有且仅有一次奇数
                if (kvp.Value % 2 == 1 && ans % 2 == 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}

