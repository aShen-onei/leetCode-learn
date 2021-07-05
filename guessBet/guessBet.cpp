// guessBet.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <cstdlib>
#include <cmath>
#include <ctime>
char randDice(int count);
int main()
{
    std::cout << "---------------------------欢迎来到BetWay--------------------------" << std::endl;
    int countine = 1, bet = 0, balance = 100, count = 0;
    wchar_t betChar='大', resChar='大';
    while (countine) {
        std::cout << "????"<< betChar << std::endl;
        std::cout << "请输入你所猜的：" << std::endl;
        betChar = std::cin.get();
        std::cin.get();
        std::cout << "请输入你的赌注：" << std::endl;
        std::cin >> bet;
        std::cout << "你猜" << betChar << "下注" << bet << std::endl;
        std::cout << "你希望骰子数量为：" << std::endl;
        std::cin >> count;
        /*
        resChar = randDice(count);
        int res = std::strcmp(&betChar, &resChar);
        std::cout << res << std::endl;
        */
        countine = 0;
    }
    return 0;
}

char randDice(int count) {
    int edge = floor((1 * count + 6 * count) / 2);
    int sum  = 0;
    unsigned seed = 0;
    for (int i = 0; i < count; i++) {
        seed = time(0);
        srand(seed);
        sum += rand() % 6 + 1;
    }
    if (sum > edge) { return '大'; }
    else { return '小'; }
}