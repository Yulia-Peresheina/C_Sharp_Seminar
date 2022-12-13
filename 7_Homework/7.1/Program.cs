//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMatrix(int row, int col, int from, int to)
{
    double[,] matrix = new double[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * (to - from) + from, 2);
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],6}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Для заполнения двумерного массива введите количество стобцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальный элемент: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальный элемент: ");
int to = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[,] matrix = FillMatrix(m, n, from, to);
PrintMatrix(matrix);