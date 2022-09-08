using System;
namespace LeetCode
{
    internal class Program
    {
        static void main(string[] args)
        {

        }
        public static bool ValidPartition(int[] nums)
        {
            // 如果要求解出划分的个数的恶时候如何求解
            int len = nums.Length;
            // 使用 DP
            bool[] flag = new bool[len + 1];
            flag[0] = true;
            for (int i = 1; i < len; i++)
            {
                // 因为是连续划分
                if (flag[i - 1] && nums[i] == nums[i - 1] ||
                    i > 1 && flag[i - 2] && (
                        (nums[i] == nums[i - 1] && nums[i] == nums[i - 2]) ||
                        (nums[i] == nums[i - 1] + 1 && nums[i] == nums[i - 2] + 2)
                     )
                )
                {
                    flag[i + 1] = true;
                }
            }
            return flag[len];
        }
    }
}