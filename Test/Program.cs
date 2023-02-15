using System;
string s = "WWEQERQWQWWRWWERQWEQ";

var qwer = new int[4];
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == 'Q') qwer[0]++;
    if (s[i] == 'W') qwer[1]++;
    if (s[i] == 'E') qwer[2]++;
    if (s[i] == 'R') qwer[3]++;
}
int std = s.Length / 4;
int ans = 0;
for (int i = 0; i < 4; i++)
{
    qwer[i] -= std;
    if (qwer[i] > 0) ans += qwer[i];
}
Console.WriteLine(ans);