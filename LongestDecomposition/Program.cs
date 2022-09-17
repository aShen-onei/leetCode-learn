using System;
namespace LongestDecomposition
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            string s = "antaprezatepzapreanta";
            string a = "ghiabcdefhelloadamhelloabcdefghi";
            string b = "aaa";
            Console.WriteLine(alg(b));
        }
        static int alg(string text)
        {
            string left = "";
            string right = "";
            int k = 0, i = 0;
            int len = text.Length;
            while (i <= len - i)
            {
                left += text[i];
                right += text[len - 1 - i];
                if (left == new string(right.Reverse().ToArray()))
                {
                    k += 2;
                    left = right = "";
                } else if (i == len - 1 -i || i == len - 2 - i)
                {
                    k++;
                }
                i++;
            }
            return k;
        }
    }
}