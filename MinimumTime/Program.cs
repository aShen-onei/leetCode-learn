using System;
namespace MinimumTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 3;
            var re = new int[2][]
            {
                new int[2] {1,3},
                new int[2] {2, 3}
            };
            var time = new int[3] { 3, 2, 5 };
            Console.WriteLine(alg(n, re, time));
            
        }
        static int alg(int n, int[][] relations, int[] time)
        {
            var hashCourse = new HashSet<int>[n + 1];
            // 入度计算
            var inDegreed = new int[n + 1];
            // 入度为0的序列
            var queue = new Queue<int>();
            var dp = new int[n + 1];
            int ans = 0, i = 0;
            // 初始化邻接表
            for (i = 1; i <= n; i++)
            {
                hashCourse[i] = new HashSet<int>();
            }
            for (i = 0; i < relations.Length; i++)
            {
                // 建立邻接表
                hashCourse[relations[i][0]].Add(relations[i][1]);
                // 由于是有序的，r[1]的这个节点，就有了一个入度
                inDegreed[relations[i][1]]++;
            }
            for (i = 1; i <= n; i++)
            {
                // 入度为0的进入，只抹除图中入度为0的节点
                if (inDegreed[i] == 0) queue.Enqueue(i);
            }
            // 遍历每个节点，并且使用dp更新每个节点所需要的课时
            while (queue.Count != 0)
            {
                // 抹除入度为0的点
                var deq = queue.Dequeue();
                // 确定当前节点的课时
                dp[deq] += time[deq - 1];
                ans = Math.Max(ans, dp[deq]);
                // 遍历后继节点，后继节点课时是需要加上前继节点的课时
                foreach (var des in hashCourse[deq])
                {
                    // 这里其实比较的是前继节点哪个最大，因为可以同时上课
                    dp[des] = Math.Max(dp[deq], dp[des]);
                    inDegreed[des]--;
                    if (inDegreed[des] == 0) queue.Enqueue(des);
                }
            }

            return ans;
        }
    }
}