// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
namespace MaxRunTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] batteries = new int[3] { 3, 3, 3 };
            
            Console.WriteLine(alg(2, batteries));
        }
        static long alg(int n, int[] batteries)
        {
            long ans = 0L;
        int i = 0, len = batteries.Length, sum = batteries.Sum();
        Array.Sort(batteries, (a, b) => b - a);
        for(i = 0; i < len && n > 0; i ++) {
            if(batteries[i] < Math.Floor((float)(sum/n))) {
                ans = batteries[i];
                break;
            } else {
                sum -= batteries[i];
                n--;
            }
        }
        if(n < 0) {
            ans = batteries[n - 1];
        }
        return ans;
        }
    }
}

