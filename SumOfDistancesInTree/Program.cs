using System;
namespace SumOfDistancesInTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 6;
            var edges = new int[5][]
            {
                new int[2] {0, 1},
                new int[2] {0, 2},
                new int[2] {2, 3},
                new int[2] {2, 4},
                new int[2] {2, 5},
            };
            try
            {
                var res = alg(n, edges);
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static int[] alg(int n, int[][] edges)
        {
            var trees = new Dictionary<int, List<int>>();
            var ans = new int[n];
            var nodeNums = new int[n];
            // 构建所有树
            foreach (int[] edge in edges)
            {
                if (trees.ContainsKey(edge[0]))
                {
                    trees[edge[0]].Add(edge[1]);
                }
                else
                {
                    trees.Add(edge[0], new List<int>() { edge[1] });
                }
                if (trees.ContainsKey(edge[1]))
                {
                    trees[edge[1]].Add(edge[0]);
                }
                else
                {
                    trees.Add(edge[1], new List<int>() { edge[0] });
                }
            }
            // 如果需要使用非递归，那就需要使用到双栈, 因为需要记住父亲节点
            // 一个是叶子结点的stack
            var leafStack = new Stack<int>();
            // 一个是有子节点的stackstack
            var parentStack = new Stack<int>();
            // 所有实例树根节点都是0，不采用换根
            int root = 0, parent = -1;
            // 先构建好叶子栈,父栈在叶子栈的构建过程中会自动构建好
            leafStack.Push(root);
            while (leafStack.Count != 0)
            {
                var pop = leafStack.Pop();
                if (trees[pop].Count == 1)
                {
                    // 如果只有一个与之相连，那么一定是父节点与之相连
                    nodeNums[pop] += 1;
                }
                else
                {
                    foreach (var child in trees[pop])
                    {
                        if (parentStack.Contains(child))
                        {
                            continue;
                        }
                        leafStack.Push(child);
                    }
                    parentStack.Push(pop);
                }
            }
            // okok 叶子节点的子树距离和节点个数都算出来了，这时候应该算非叶子节点的了
            while (parentStack.Count != 0)
            {
                var par = parentStack.Pop();
                // 初始化nodenum
                nodeNums[par] = 1;
                // 这里，child会包含到当前的par的父节点，但是由于是栈结构，
                // 父节点还没有被赋值，所以不。用管父节点
                foreach (var child in trees[par])
                {
                    if (parentStack.Contains(child))
                    {
                        continue;
                    }
                    nodeNums[par] += nodeNums[child];
                    ans[par] += nodeNums[child] + ans[child];
                }
            }
            // okok，子树已经构建好了，现在来计算非子树的了
            // 这里就需要使用到子树栈，用parentstack代替吧，
            // root根节点的sum自下而上已经是确定的了，那么以每个为根的需要替换
            leafStack.Clear();
            parentStack.Clear();
            leafStack.Push(root);
            while (leafStack.Count != 0)
            {
                var leaf = leafStack.Pop();
                foreach (var child in trees[leaf])
                {
                    if (parentStack.Contains(child))
                    {
                        continue;
                    }
                    else
                    {
                        ans[child] = ans[leaf] - nodeNums[child] + (n - nodeNums[child]);
                        leafStack.Push(child);
                    }
                }
                parentStack.Push(leaf);
            }
            return ans;
        }
    }
}