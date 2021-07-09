using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 121;
            Console.WriteLine(IsPalin(x));
        }
        /// <summary>
        /// 比较简单的回文数检测，主要的核心是数字的反转reverse
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static Boolean IsPalin(int x)
        {
            int s = x;
            if (x < 0) return false;
            int sum = 0;
            while(x != 0)
            {
                sum = sum * 10 + (x % 10);
                x /= 10;
            }
            return sum == s;
        }
    }
}
