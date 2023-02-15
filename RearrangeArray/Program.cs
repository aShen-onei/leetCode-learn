using System;
namespace RearrangeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5] { 10, 7, 5, 4, 3 };
            var res = alg(nums);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        static int[] alg(int[] nums)
        {
            int i = 0, temp = 0;
            while (i < nums.Length - 1)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                if ((float)nums[i] == (float)((nums[i - 1] + nums[i + 1]) / 2.0))
                {
                    temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                    // 回溯前一个
                    i--;
                }
                else
                {
                    i++;
                }
            }
            return nums;
        }
    }
}