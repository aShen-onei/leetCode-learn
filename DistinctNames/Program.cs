using System;
using System.Collections.Generic;

namespace DistinctNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ideas = new string[4] {"coffee", "donuts", "time", "toffee"};
            Console.WriteLine(alg(ideas));
        }
        static int alg(string[] ideas)
        {
            var group = new HashSet<string>[26];
            for (var i = 0; i < 26; i++) group[i] = new HashSet<string>();
            foreach (var s in ideas) group[s[0] - 'a'].Add(s.Substring(1));
            var ans = 0;
            for (var i = 1; i < 26; ++i)
                for (var j = 0; j < i; ++j)
                {
                    var m = 0;
                    foreach (var s in group[i])
                    {
                        if (group[j].Contains(s)) ++m;
                    }
                    ans += (group[i].Count - m) * (group[j].Count - m);
                }
            return ans * 2;
        }
    }
}