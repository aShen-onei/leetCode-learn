using System;
using System.Linq;
namespace MinMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6] { 1, 0, 0, 1, 0, 5 };
            Array.Reverse(nums);
            Console.WriteLine(nums[0]);
            int k = 2;
            // Console.WriteLine(MinMoves(nums, k));
        }
        static int MinMoves(int[] nums, int k)
        {
            List<int> zeros = new List<int>();
            int i = 0, j = 0;
            while (i < nums.Length && nums[i] == 0) i++;
            while (i < nums.Length)
            {
                // 窗口
                j = i + 1;
                while (j < nums.Length && nums[j] == 0) j++;
                if (j < nums.Length)
                {
                    zeros.Add(j - i - 1);
                }
                i = j;
            }
            // 构造前缀和
            List<int> preSum = new List<int>();
            preSum.Add(0);
            i = 0;
            int sum = 0;
            for (i = 0; i < zeros.Count; i++)
            {
                sum += zeros[i];
                preSum.Add(sum);
            }
            // 求第一个滑动窗口的cost
            i = 0; j = 0;
            int minCost = 0, cost = 0, mid = 0;
            for (i = 0; i <= k - 2; i++)
            {
                cost += zeros[i] * Math.Min(i - 0 + 1, k - 2 - i + 1);
            }
            minCost = cost;
            for (i = 1, j = i + k - 2; j < zeros.Count; i++, j++)
            {
                mid = (i + j) / 2;
                cost -= (preSum[mid] - preSum[i - 1]);
                cost += (preSum[j + 1] - preSum[mid + k % 2]);
                minCost = Math.Min(minCost, cost);
            }
            return minCost;
        }
    }
}
