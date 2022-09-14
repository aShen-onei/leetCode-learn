using System;
namespace FindLonely
{
    internal class Profram
    {
        static void Main(string[] args)
        {
            int[] nu = new int[4] { 10, 6, 5, 8 };
            var list = alg(nu);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static IList<int> alg(int[] nums) {
            Dictionary<int, int> oneArray = new Dictionary<int, int>();
            List<int> ans = new List<int>();
            // 计数
            foreach (int n in nums)
            {
                if (oneArray.ContainsKey(n))
                {
                    oneArray[n]++;
                }
                else
                {
                    oneArray.Add(n, 1);
                }
            }
            foreach (KeyValuePair<int, int> kv in oneArray)
            {
                if (!oneArray.ContainsKey(kv.Key - 1) &&
                   !oneArray.ContainsKey(kv.Key + 1) &&
                   oneArray[kv.Key] == 1)
                {
                    ans.Add(kv.Key);
                }
            }
            return ans;
        }
    }
}
