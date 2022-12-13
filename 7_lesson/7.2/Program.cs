// 2. Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные, и замените эти элементы на их квадраты

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


void MatrixPowEven(int [,] arr)                     //возведение в квадрат четных индексов
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
                arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
        }
    }
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



Console.WriteLine("Для заполнения двумерного массива введите количество стобцов:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите минимальный элемент:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальный элемент:");
int to = int.Parse(Console.ReadLine()!);

int[,] matrix = FillMatrix(m, n, from, to);
PrintMatrix(matrix);

MatrixPowEven(matrix);
PrintMatrix(matrix);
