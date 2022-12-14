// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

double [] AverageCol(int[,] arr)                          //вариант  1. Создаем массив значений. Можно работать дальше.
{
    double [] averages = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
            averages[i] = Math.Round(Convert.ToDouble(arr[j, i])/arr.GetLength(1),2) + averages[i];
    }
    return averages;
}

// void AverageCol(int[,] arr)                          //вариант  2. Просто выводим среднее арифметическое.
// {
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         double averages = 0;
//         for (int j = 0; j < arr.GetLength(0); j++)
//             averages = arr[j, i] + averages;
//         Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {Math.Round(averages/arr.GetLength(1), 2)}");
//     }
// }


void PrintArray(double[] array)                   //для вывода массива средних арифметических
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
        Console.Write($" {array[i]} ");
    Console.WriteLine();
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],6}");
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

int[,] matrix = FillMatrix(m, n, from, to);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArray(AverageCol(matrix));                              //для вывода массива средних арифметических
// AverageCol(matrix);
