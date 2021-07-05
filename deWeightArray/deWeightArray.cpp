// deWeightArray.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <algorithm>
#include <vector>

int removeDuplicates(std::vector<int>& nums) {
    nums.erase(std::unique(nums.begin(), nums.end()), nums.end());
    return nums.size();
}
int main()
{
    std::vector<int> num = { 1,1,1,2,3 };
    int len = removeDuplicates(num);
    std::cout << len << std::endl;
}
