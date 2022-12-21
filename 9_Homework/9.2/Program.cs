// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

int SumNumBetween(int M, int N)
{
    if (M > N) return 0;
    return M + SumNumBetween(M + 1, N);
}

Console.WriteLine(SumNumBetween(int.Parse(Console.ReadLine()!),
                                int.Parse(Console.ReadLine()!)));