using System.Linq.Expressions;
var testStr = "111222";
var strArray = new List<string>();
string sum = "";
int i, j;
for (i = 0; i < testStr.Length; i++) {
    j = i;
    sum = "";
    // 这个循环控制分割多少个字符
    for(j = i; j <= i + 1;j++)
    {
        sum += testStr[j];
    }
    strArray.Add(sum);
    i = j - 1;
}
var ans = "";
for(int k = strArray.Count - 1; k >=0; k--)
{
    ans += strArray[k];
}
Console.WriteLine(ans);

var nums = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
nums.Max();

/*
var nums = new int[7] { 1,2,3,4,5,6,7};
var k = 4;
int len = nums.Length, bond = len - k;
double ans = 0;
Array.Sort(nums);
int sum = 0;
for (int i = 0; i <= bond; i++)
{
    sum += nums[i];
}
bond++;
ans = (double)(sum / bond);
for (int i = bond; i < len; i++)
{
    ans += (double)nums[i];
}
Console.WriteLine(ans);
/*
string s = "abcde";
var words = new string[4] { "a", "bb", "acd", "ace" };
int ans = 0, len = words.Length;
foreach (string word in words)
{
    int i = 0;
    string com = "";
    foreach (char c in word)
    {
        while (i < s.Length && s[i] != c) i++;
        if (i < s.Length) com += c;
    }
    if (com == word) ans++;
}
Console.WriteLine(ans);
///
/// 二分查找
///
/*
public int BinarySearch(IList<int> list, int target)
{
    int left = 0, right = list.Count - 1;
    while (left < right)
    {
        int mid = left + (right - left) / 2;
        if (list[mid] > target)
        {
            right = mid;
        }
        else
        {
            left = mid + 1;
        }
    }
    return list[left];
}
*/
/*
string expression = "|(f,f,f,t)";
var optor = new Stack<char>();
var str = new Stack<HashSet<char>>();
var opAry = new char[3] { '!', '|', '&' };
var dic = new Dictionary<char, bool>() {
            {'t', true},
            {'f', false}
        };
var hash = new HashSet<char>();
foreach (var c in expression)
{
    if (opAry.Contains(c))
    {
        optor.Push(c);
    }
    else if (c == '(')
    {
        var newHash = new HashSet<char>();
        foreach (var m in hash)
        {
            newHash.Add(m);
        }
        str.Push(newHash);
        hash.Clear();
    }
    else if (c == ')')
    {
        var h = str.Pop();
        var op = optor.Pop();
        if (hash.Count == 1)
        {
            if (op == '!')
            {
                foreach (var k in hash)
                {
                    if (k == 'f') h.Add('t');
                    else if (k == 't') h.Add('f');
                }
            }
            else
            {
                foreach (var k in hash)
                {
                    h.Add(k);
                }
            }
            hash = h;
        }
        else
        {
            if (op == '&')
            {
                h.Add('f');
            }
            else if (op == '|')
            {
                h.Add('t');
            }
            hash = h;
        }
    }
    else if (c == ',')
    {
        continue;
    }
    else
    {
        hash.Add(c);
    }
}
var ans = new char[1];
hash.CopyTo(ans);
return !(ans[0] == 'f');
*/