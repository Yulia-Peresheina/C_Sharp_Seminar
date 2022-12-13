// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
void FindPosition(int[,] arr, int a, int b)
{
    if (a - 1 >= 0 &&
        a <= arr.GetLength(0) &&
        b - 1 >= 0 &&
        b <= arr.GetLength(1))
    {
        Console.WriteLine($"Элемент с позициями {a}, {b} имеет значение {arr[a - 1, b - 1]}.");
        return;
    }
    Console.WriteLine($"Элемент с позициями {a}, {b} в массиве отствует.");
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

Console.Write("Для заполнения двумерного массива введите количество стобцов:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальный элемент:");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальный элемент:");
int to = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию строки искомого элемента: ");
int elementRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца искомого элемента: ");
int elementCol = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix = FillMatrix(m, n, from, to);
PrintMatrix(matrix);
FindPosition(matrix, elementRow, elementCol);
