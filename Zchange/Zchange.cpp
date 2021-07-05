/*
    Z字形变换
*/
#include <iostream>
#include <string>

std::string convert(std::string s, int rows) {
    int middleRow = rows - 2; // 中间的行数
    int zRows = rows + middleRow; // 一个整形Z字符串的个数
    std::string zString = "";
    int i = 0,j = 0;
    while (j<s.length())
    {
        std::cout << s[i] << std::endl;
        i += zRows;
        if (i > s.length()) {
            i = i % s.length() - 1;
        }
        j++;
    }
    return s;
}

int main()
{
    std::string s = "LEETCODEISHIRING";
    int rows = 3;
    std::cout << convert(s, rows) << std::endl;
}
