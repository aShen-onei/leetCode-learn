using System;

namespace IntReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = -2147483412;
            Console.WriteLine(MathReserve(k));
        }
        public static int Reverse(int x)
        {
            var sign = x > 0;
            var stringX = Math.Abs(x).ToString();
            var newX = "";
            for (int i = stringX.Length - 1; i >= 0; i--)
            {
                newX += stringX[i];
            }

            return sign ? 0 + int.Parse(newX) : 0 - int.Parse(newX);
        }
        /// <summary>
        /// 数学的数字反转，取余弹出最末尾的数字，放入到反转的数字组中，每次放入反转数字中反转加一位放入，即*10，添加位
        /// 不能超过int的数量
        /// 解不等式
        /// MIN_INT<res * 10 +  mod<MAX_INT
        /// MIN_INT - MOD/10 < res< MAX_INT -MOD /10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MathReserve(int x)
        {
            int res = 0;
            int mod = 0;
            while (x != 0)
            {
                if (res < int.MinValue / 10 || res > int.MaxValue / 10) return 0;

                mod = x % 10;
                x /= 10;
                res = res * 10 + mod;
            }
            return res;
        }
    }
}
