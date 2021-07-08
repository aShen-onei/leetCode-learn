using System;
using System.Globalization;

namespace aoti
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = " -42";
            Console.WriteLine(aoti(x));
        }
        /// <summary>
        /// 这里的这个问题是https://leetcode-cn.com/problems/string-to-integer-atoi/
        /// 类C++的atoi函数实现，这里的逻辑清晰的写了出来，主要考察的是需要考虑多个方面的地方
        /// 考虑周全才能够AC，可以引入自动机的概念，详细可见leetcode解答（就是把所有情况都罗列，每一步的状态罗列出来
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int aoti(string s)
        {
            s = s.Trim();
            Boolean sign = s[0] == '-';
            var str = "";

            long res = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (Int64.TryParse(s[i].ToString(), out res))
                {
                    str += s[i];
                } else if (s[i] == '+' || s[i] == '-')
                {
                    continue;
                } else
                {
                    break;
                }
            }
            res = str.Length == 0 ? 0 : int.Parse(str);
            if (res > int.MaxValue)
            {
                res = int.MaxValue;
            } else if (res < int.MinValue)
            {
                res = int.MinValue;
            }
            return sign ? (int)res * -1 : (int)res;
        }
    }
}
