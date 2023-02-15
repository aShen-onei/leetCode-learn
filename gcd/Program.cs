// See https://aka.ms/new-console-template for more information
///
/// 最大公约数函数求解方法
///
int gcd(int num1, int num2)
{
    while (num2 != 0)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp % num2;
    }
    return num1;
}

