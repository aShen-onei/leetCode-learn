// See https://aka.ms/new-console-template for more information
using System;
namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "atbbga";
            Console.WriteLine(alg(s));
        }
        static bool alg(string s)
        {
            int i = 0;
            bool left = false, right = false;
            int len = s.Length - 1;
            while (i < len)
            {
                if (s[i] == s[len])
                {
                    i++;
                    len--;
                }
                else
                {
                    break;
                }
            }
            if (i >= len)
            {
                return true;
            }
            int lefti = i;
            int rightlen = len - 1;
            while (lefti <= rightlen)
            {
                if (s[lefti] == s[rightlen])
                {
                    lefti++;
                    rightlen--;
                }
                else
                {
                    left = false;
                    break;
                }
                left = true;
            }
            lefti = i + 1;
            rightlen = len;
            while (lefti <= rightlen)
            {
                if (s[lefti] == s[rightlen])
                {
                    lefti++;
                    rightlen--;
                }
                else
                {
                    right = false;
                    break;
                }
                right = true;
            }
            return left || right;
        }
    }

}


