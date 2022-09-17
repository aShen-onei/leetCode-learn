using System;
namespace FindMinFibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static int alg(int k)
        {
            int ans = 0;
            int a = 1, b = 1;
            List<int> fibonacci = new List<int>();
            fibonacci.Add(a);
            fibonacci.Add(b);
            while (a + b <= k)
            {
                int temp = a + b;
                fibonacci.Add(temp);
                a = b;
                b = temp;
            }
            for (int i = fibonacci.Count - 1; k > 0 && i >= 0; i--)
            {
                int num = fibonacci[i];
                if (k >= num)
                {
                    k -= num;
                    ans++;
                }
            }
            // while(cloneK > 0) {
            //     if(fibonacci.Count < i + 1) {
            //         fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            //     }
            //     if(fibonacci[i] > cloneK) {
            //         cloneK = cloneK - fibonacci[i - 1];
            //         ans++;
            //         i = 2;
            //     } else if (fibonacci[i] == cloneK) {
            //         cloneK = cloneK - fibonacci[i];
            //         ans++;
            //     }
            //     i++;
            // }
            return ans;
        }
    }
}
