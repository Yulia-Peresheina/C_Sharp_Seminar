// Задайте значение N. Напишите программу, которая выведет
// все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void EwenToNum(int N)
{
    if (N % 2 != 0) N = N - 1;
    if (N < 0) return;
    if (N == 0) return;
    Console.Write($"{N} ");
    EwenToNum(N - 2);
}
EwenToNum(int.Parse(Console.ReadLine()!));