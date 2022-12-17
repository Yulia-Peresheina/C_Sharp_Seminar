// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] FillMatrix(int row, int col, int from, int to)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(from, to);
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

string FindMinRow(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            sum[i] = sum[i] + matr[i, j];
    }
    int l = 0;
    for (int k = 0; k < sum.Length; k++)
        if (sum[k] < sum[l]) l = k;
    return $"Минимальное значение суммы элементов у строки {l+1}";
}
Console.WriteLine("Для заполнения двумерного массива введите количество стобцов:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальный элемент:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальный элемент:");
int to = int.Parse(Console.ReadLine()!);

int[,] matrix = FillMatrix(m, n, from, to);
PrintMatrix(matrix);
Console.WriteLine(FindMinRow(matrix));