using System;

namespace smallestRepunit
{
    class Program
    {
        /// <summary>
        /// 贪心算法+动态规划
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Smallest(1));
        }
        static int Smallest(int k)
        {
            if (k % 2 == 0 || k % 5 == 0) return -1;    
            return k;
        }
    }
}
