// longestPalindrome.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
// 最长回文子串

#include <iostream>
#include <string>
#include <algorithm>

struct moveWindow {
    int begin;
    int end;
    int sum;
};
void longestPalindrome(std::string s) {
    std::string Rs = s;
    reverse(Rs.begin(), Rs.end());
    moveWindow win;
    win.begin = 0;
    win.sum = 0;
    for (int i = 0; i < s.length(); i++) {
        if (s[i] == s[win.begin]) {
            win.end = i;
            if (Rs[s.length() - win.end + 1] == Rs[s.length() - win.begin + 1]) {
                int sum = win.end - win.begin;
                if (sum > win.sum) win.sum = sum;

            }
        }
    }
    std::cout << s.substr( - 1,  - 1) << std::endl;
}

int main()
{
    longestPalindrome("babad");
    return 0;
}
