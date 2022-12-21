// 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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

void ChangeRow(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        (arr[0, j], arr[arr.GetLength(0)-1, j]) = (arr[arr.GetLength(0) - 1, j], arr[0, j]);
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

// Console.WriteLine("Для заполнения двумерного массива введите количество стобцов:");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество строк:");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.WriteLine("Введите минимальный элемент:");
// int from = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите максимальный элемент:");
// int to = int.Parse(Console.ReadLine()!);

int [,] matrix = FillMatrix(4, 4, 1, 10);
PrintMatrix(matrix);

ChangeRow(matrix);
PrintMatrix(matrix);
