// 2. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.


int [,] FillMatrix (int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = i+j;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j], 4}");
        Console.WriteLine();
    }
}



Console.WriteLine("Для заполнения двумерного массива введите количество стобцов:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int [,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);