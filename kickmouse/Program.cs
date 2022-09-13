using System;
using System.Linq;
namespace KickMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[5][]
            {
                new int[3] {2, 0, 2},
                new int[3] {6, 2, 0},
                new int[3] {4, 1, 0},
                new int[3] {2, 2, 2},
                new int[3] {3, 0, 2}
            };
            Console.WriteLine(alg(nums));
        }
        static int alg(int[][] nums)
        {

            List<int[]> a = new List<int[]>();
            a.Add(new int[3] { 0, 1, 1 });
            bool flag = false;
            foreach (int[] v in nums)
            {
                if (v[0] == 0)
                {
                    if (v[1] == 1 && v[2] == 1)
                    {
                        flag = true;
                    }
                } else
                {
                    a.Add(v);
                }
            }
            a.Sort((a, b) => a[0] - b[0]);
            // fn 标识从0到n的最多次数
            int[] f = new int[a.Count];
            int[] g = new int[a.Count];
            int ans = 0;
            for (int i = 1; i < a.Count; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    int t = a[i][0] - a[j][0];
                    int dis = Math.Abs(a[i][1] - a[j][1]) + Math.Abs(a[i][2] - a[j][2]);
                    if (t > 4)
                    {
                        f[i] = Math.Max(f[i], g[j] + 1);
                        break;
                    }
                    else if (dis <= t)
                    {
                        f[i] = Math.Max(f[i], f[j] + 1);
                    }
                }
                ans = Math.Max(f[i], ans);
                g[i] = Math.Max(g[i - 1], f[i]);
            }
            return ans + (flag ? 1 : 0);
        }
    }
}
