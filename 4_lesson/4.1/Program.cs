// 1. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int CountNum(int num)
{
    int result = 1;
    
    while (num > 9 || num < -9)
    {
        num = num/10;
        result++;
    }
    return result;
}

Console.WriteLine(CountNum(1234567891));

// 2 вариант через строку

int CountNum2(int num)
{
    string number = num.ToString();
    int result2 = number.Length;
    return result2;
}
Console.WriteLine(CountNum2(1234567891));