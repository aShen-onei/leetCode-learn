using System;
namespace ProductExceptSelf
{
    internal class Program
    {
        static void main(string[] args)
        {

        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] ans = new int[len];
            int[] bns = new int[len];
            ans[0] = 1;
            bns[len - 1] = 1;
            for (int i = 1; i < len; i++)
            {
                ans[i] = nums[i - 1] * ans[i - 1];
                bns[len - i - 1] = nums[len - i] * bns[len - i];
            }
            for (int j = 0; j < len; j++)
            {
                ans[j] *= bns[j];
            }
            return ans;
        }
     }
}
