using System;
namespace LongestCommonSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "oxcpqrsvwf";
            string b = "shmtulqrypy";
            Console.WriteLine(alg(a, b));

        }
        static int alg(string text1, string text2)
        {
            int lastPos = -1, curPos = 0, ans = 0, currmax = 0;
            for (int i = 0; i < text1.Length; i++)
            {
                if (text2.Contains(text1[i]))
                {
                    curPos = text2.IndexOf(text1[i], lastPos + 1, text2.Length - lastPos - 1);
                    if (curPos > lastPos)
                    {
                        lastPos = curPos;
                        ans++;
                    }
                    else if (curPos != -1)
                    {
                        lastPos = curPos;
                        currmax = Math.Max(ans, currmax);
                        ans = 1;
                    }
                }
            }
            return Math.Max(currmax, ans);
        }
    } 
}