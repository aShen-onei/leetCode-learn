using System;
namespace LongestRepeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "babacc";
            var b = "bcb";
            var t = new int[3] { 1, 3, 3 };
            var sol = new Solution();
            var res = sol.LongestRepeating(a, b, t);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Solution
    {
        IList<int> left, right, all;
        char[] news;

        public void build(int node, int l, int r)
        {
            if (l == r)
            {
                left[node] = right[node] = all[node] = 1;
            }
            else
            {
                // 先往左边构建，优先构建左子树
                int m = (l + r) / 2;
                build(node << 1, l, m);
                build(node << 1 | 1, m + 1, r);
                merge(node, l, r);
            }
        }
        // 合并数据, l是左边界， r是右边界
        public void merge(int node, int l, int r)
        {
            // 先找出左右节点的节点下标，以及中间的位置，中间需要特殊处理下
            int nl = node << 1, nr = node << 1 | 1, m = (l + r) / 2;
            // 当前节点的最大重复长子串就是左右节点的最大值
            all[node] = Math.Max(all[nl], all[nr]);
            left[node] = left[nl];
            right[node] = right[nr];
            // 如果中间相等，那么左部的右边最大值要与右部的左部最大值相加，再比较刚才计算的all，然后更新
            if (news[m] == news[m + 1])
            {
                all[node] = Math.Max(all[node], left[nr] + right[nl]);
                if (all[nl] == m - l + 1)
                {
                    left[node] += left[nr];
                }
                if (all[nr] == r - m)
                {
                    right[node] += right[nl];
                }
            }
        }
        public int update(int node, int l, int r, int i, char c)
        {
            if (l == r)
            {
                news[l] = c;
            }
            else
            {
                int m = (l + r) / 2;
                if (i <= m)
                {
                    update(node << 1, l, m, i, c);
                }
                else
                {
                    update(node << 1 | 1, m + 1, r, i, c);
                }
                merge(node, l, r);
            }
            return all[node];
        }
        public int[] LongestRepeating(string s, string queryCharacters, int[] queryIndices)
        {
            news = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                news[i] = s[i];
            }
            var count = s.Length << 2;
            left = new List<int>(count);
            right = new List<int>(count);
            all = new List<int>(count);
            build(1, 0, s.Length - 1);
            var ans = new List<int>();
            for (int i = 0; i < queryCharacters.Length; i++)
            {
                int res = update(1, 0, s.Length - 1, queryIndices[i], queryCharacters[i]);
                ans.Add(res);
            }
            return ans.ToArray();
        }
    }
}