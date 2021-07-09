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
        /// 还有个比较牛逼的方法，就是只比较中间到后面的数字，也就是
        /// sum = sum * 10 + (x % 10);
        /// x /= 10
        /// 这个只需要执行一半，怎么才知道是一半呢？
        /// x/=10之后的值和sum相比，如果x等于sum或者小于sum这不就一半或者超过一半了吗？🐂🍺
        /// https://leetcode-cn.com/problems/palindrome-number/solution/hui-wen-shu-by-leetcode-solution/
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
