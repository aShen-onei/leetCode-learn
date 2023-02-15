using System;
using System.Text;

namespace WiggleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new string[2] { "S.C.P#P.", ".....#.S" };
            var k = words[0].Reverse().ToString();
            var v = new StringBuilder("111");
            v[0] = 'a';
            Console.WriteLine(v);

        }
    }

    public class Solution
    {
        public int GuardCastle(string[] grid)
        {
            var charGrid = new char[2][];
            var charGrid2 = new char[2][];
            charGrid[0] = grid[0].ToCharArray();
            charGrid[1] = grid[1].ToCharArray();
            charGrid2[0] = grid[0].ToCharArray();
            charGrid2[1] = grid[1].ToCharArray();
            for (int i = 0; i < charGrid[0].Length; i++)
            {
                if (charGrid[0][i] == 'P') charGrid[0][i] = 'S';
                if (charGrid[1][i] == 'P') charGrid[1][i] = 'S';
            }
            for (int i = 0; i < charGrid2[0].Length; i++)
            {
                if (charGrid2[0][i] == 'P') charGrid2[0][i] = 'C';
                if (charGrid2[1][i] == 'P') charGrid2[1][i] = 'C';
            }
            var a = check(charGrid, grid);
            var b = check(charGrid2, grid);
            var ans = Math.Min(a, b);
            return ans;
        }
        public int check(char[][] charGrid, string[] grid)
        {
            var m = charGrid[0].Length;
            var max = int.MaxValue;
            var ans = 0;
            if (charGrid[0][0] == '.' && charGrid[1][0] != '.')
            {
                charGrid[0][0] = charGrid[1][0];
            }
            else if (charGrid[0][0] != '.' && charGrid[1][0] == '.')
            {
                charGrid[1][0] = charGrid[0][0];
            }
            for (int i = 1; i < m; i++)
            {
                if (charGrid[0][i] == '.')
                {
                    // 有空地的先转换
                    charGrid[0][i] = charGrid[0][i - 1];
                }
                if (charGrid[1][i] == '.')
                {
                    charGrid[1][i] = charGrid[1][i - 1];
                }
                if (charGrid[0][i] == 'C')
                {
                    if (charGrid[0][i - 1] == 'S' && grid[0][i - 1] == '.')
                    {
                        ans++;
                    }
                    if (i != m - 1 && charGrid[0][i + 1] == 'S' && grid[0][i] == '.')
                    {
                        ans++;
                    }
                    if (charGrid[1][i] == 'S' && grid[1][i] == '.')
                    {
                        charGrid[1][i] = '#';
                        ans++;
                    }
                }
                if (charGrid[1][i] == 'C')
                {
                    if (charGrid[1][i - 1] == 'S' && grid[1][i - 1] == '.')
                    {
                        ans++;
                    }
                    if (i != m - 1 && charGrid[1][i + 1] == 'S' && grid[1][i] == '.')
                    {
                        ans++;
                    }
                    if (charGrid[0][i] == 'S' && grid[0][i] == '.')
                    {
                        charGrid[0][i] = '#';
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}