using System;

namespace IntReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1534236469;
            Console.WriteLine(Reverse(k));
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
    }
}
