using System;
namespace BallGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 4;
            var plate = new string[3] {"..E.", ".EOW", "..W."};
            var sol = new Solution();
            foreach (var item in sol.BallGame(num, plate))
            {
                Console.WriteLine($"[{item[0]}, {item[1]}]");
            }
        }
    }
    public class Solution
    {
        int[][] DIR = new int[4][] {
            new int[2]{0, 1},
            new int[2]{1, 0},
            new int[2]{0, -1},
            new int[2]{-1, 0}
        };
        public int[][] BallGame(int num, string[] plate)
        {
            var rows = plate.Length;
            var cols = plate[0].Length;
            var ans = new List<int[]>();
            for (int i = 1; i < cols - 1; i++)
            {
                if (plate[0][i] == '.' && go(0, i, 1, num, plate, rows, cols)) ans.Add(new int[2] { 0, i });
                if (plate[rows - 1][i] == '.' && go(0, i, 3, num, plate, rows, cols)) ans.Add(new int[2] { rows - 1, i });
            }
            for (int i = 1; i < rows - 1; i++)
            {
                if (plate[i][0] == '.' && go(0, i, 0, num, plate, rows, cols)) ans.Add(new int[2] { i, 0 });
                if (plate[i][cols - 1] == '.' && go(0, i, 2, num, plate, rows, cols)) ans.Add(new int[2] { i, rows - 1 });
            }
            return ans.ToArray();
        }
        public bool go(int x, int y, int d, int num, string[] plate, int row, int col)
        {
            int left = num;
            while (plate[x][y] != 'O')
            {
                if (left == 0) return false;
                if (plate[x][y] == 'W')
                {
                    d = (d + 3) % 4;
                }
                else if (plate[x][y] == 'E')
                {
                    d = (d + 1) % 4;
                }
                x += DIR[d][0];
                y += DIR[d][1];
                if (x < 0 || x >= row - 1 || y < 0 || y >= col - 1) return false;
                left--;
            }
            return true;
        }
    }
}