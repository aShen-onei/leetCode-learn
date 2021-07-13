using System;
using System.Collections.Generic;

namespace IsMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMatch("aab", "c*a*b"));
        }
        /// <summary>
        /// 字符串匹配，有点难，官方使用动态规划，我这样用了自动机。。。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        static Boolean IsMatch(string s, string p)
        {
            Queue<char> listp = new Queue<char>();
            Queue<char> lists = new Queue<char>();
            foreach (var item in p)
            {
                listp.Enqueue(item);
            }
            foreach (var item in s)
            {
                lists.Enqueue(item);
            }
            string res = "";
            char pre = ' ';
            while (lists.Count != 0)
            {
                if (listp.Count == 0) break;
                var rep = listp.Peek();
                var ps = lists.Peek();
                if (ps == rep)
                {
                    res += ps;
                    listp.Dequeue();
                    lists.Dequeue();
                    pre = rep;
                }
                else if (rep == '*')
                {
                    if (ps == pre || pre == '.')
                    {
                        res += ps;
                        lists.Dequeue();
                        continue;
                    }
                    else
                    {
                        listp.Dequeue();
                        pre = '*';
                        if (listp.Count == 0) break;
                        rep = listp.Peek();
                    }
                }
                else if (rep == '.')
                {
                    res += ps;
                    listp.Dequeue();
                    lists.Dequeue();
                    pre = '.';
                }
                else
                {
                    res += listp.Dequeue();
                }
            }

            return res.Contains(s);
        }
    }
}
