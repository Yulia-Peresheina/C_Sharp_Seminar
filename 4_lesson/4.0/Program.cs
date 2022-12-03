// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.


int Sum(int A)
{
    int[] sum = new int[A];
    Console.WriteLine($"{A} -> ");
    int result = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        sum[i] = i + 1;
        result = result + sum[i];
    }
    return result;
}

Console.WriteLine(Sum(15));

// 2 вариант
int SumNums(int A)
{
    int result = 0;
    for (int i = 0; i <= A; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine(SumNums(15));