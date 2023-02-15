using System;
namespace MaxDiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            Console.WriteLine(alg(a));
        }
        static int alg(int num)
        {
            int maxa = 0;
            int minb = 0;
            bool change = false;
            char temp = 'a';
            string numString = num.ToString();
            string maxString = "";
            string minString = "";
            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] != '9' && !change)
                {
                    temp = numString[i];
                    maxString += '9';
                    change = true;
                }
                else if (numString[i] == temp && change)
                {
                    maxString += '9';
                }
                else
                {
                    maxString += numString[i];
                }
            }
            temp = 'a';
            change = false;
            char addNum = '0';
            for (int j = 0; j < numString.Length; j++)
            {
                if (numString[j] != '1' && j == 0)
                {
                    addNum = '1';
                    temp = numString[j];
                    minString += addNum;
                    change = true;
                }
                else if (numString[j] != '0' && j != 0 && !change && numString[j] != numString[0])
                {
                    addNum = '0';
                    temp = numString[j];
                    minString += addNum;
                    change = true;
                }
                else if (numString[j] == temp && change)
                {
                    minString += addNum;
                }
                else
                {
                    minString += numString[j];
                }
            }
            maxa = Int32.Parse(maxString);
            minb = Int32.Parse(minString);
            return maxa - minb;
        }
    }
}
