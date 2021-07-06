// Z-change.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <string>
#include <vector>

using namespace std;
std::string convert(std::string s, int rows) {
    std::string sub = "";
    int stdNum = rows + (rows - 2);
    for (int i = 0; i < rows; i++) {
        int addNum = stdNum - (i * 2);
        for (int j = i; j < s.length(); j += addNum) {
            sub += s[j];
        }
    }
    return sub;
}
std::string leetcode(std::string s, int rowNum) {
    // 如果当前只分一行，则返回
    if (rowNum == 1) return s;
    // 判断有多少个非空行数，就创建多少个字符串数组用来存放
    vector<string> rows(min(rowNum, int(s.size())));
    // 当前的行数
    int currRow = 0;
    // 当前的方向，如果是向下正向，则行数+1，如果到底部，方向要反转，行数-1
    bool dir = false;
    for (char c : s) {
        rows[currRow] += c;
        if (currRow == 0 || currRow == rowNum - 1) dir = !dir;
        currRow += dir ? 1 : -1;
    }
    string res = "";
    for (string row : rows) {
        res += row;
    }
    return res;

}
int main()
{
    std::string s = "PAYPALISHIRING";
    std::string res = leetcode(s, 3);
    std::cout << res << std::endl;
}
// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门使用技巧: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件
