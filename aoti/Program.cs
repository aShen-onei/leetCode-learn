using System;
using System.Globalization;

namespace aoti
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "1231231";
            Console.WriteLine(aoti(x));
        }
        public static int aoti(string x)
        {
            Boolean sign = true;
            var str = "";
            x.Trim();
            int number;
            foreach (var c in x)
            {
                if (Int32.TryParse(c.ToString(), out number))
                {
                    str += c;
                }
            }
            var res = int.Parse(str);
            if (res > int.MaxValue || res < int.MinValue)
            {
                res = 0;
            }
            return res;
        }
    }
}
