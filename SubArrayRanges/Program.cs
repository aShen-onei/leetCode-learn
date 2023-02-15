using System;
namespace SubArrayRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[3] { 1, 2, 3 };
            string s = "aaaa";
            var a = s.ToCharArray();
            var len = nums.Length;
            var sum = 0;
            Array.Sort(nums);
            var mid = len / 2;
            for (int i = 0; i <= mid; i++)
            {
                sum += (nums[i] - nums[len - 1 - i]);
            }
            Console.WriteLine(sum);
        }
    }
}