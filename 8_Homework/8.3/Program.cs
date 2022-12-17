// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


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

int[,] MatrixMultiplikation(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        int[,] newMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < newMatr.GetLength(0); i++)
        {
            for (int j = 0; j < newMatr.GetLength(1); j++)
            {
                for (int k = 0; k < matr1.GetLength(1); k++)
                    newMatr[i, j] = newMatr[i, j] + (matr1[i, k] * matr2[k, j]);
            }
        }
        return newMatr;
    }
    else
    {
        Console.WriteLine("Количество столбцов 1 массива не равно количесту строк 2 массива");
        return null!;
    }
}

Console.WriteLine("Для заполнения 1 двумерного массива введите количество строк:");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальный элемент 1 массива:");
int from1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальный элемент 1 массива:");
int to1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Для заполнения 2 двумерного массива введите количество строк:");
int m2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов:");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальный элемент 2 массива:");
int from2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальный элемент 2 массива:");
int to2 = int.Parse(Console.ReadLine()!);
Console.Clear();

int[,] matrix1 = FillMatrix(m1, n1, from1, to1);
int[,] matrix2 = FillMatrix(m2, n2, from2, to2);
Console.WriteLine("1 массив:");
PrintMatrix(matrix1);
Console.WriteLine("2 массив:");
PrintMatrix(matrix2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(MatrixMultiplikation(matrix1, matrix2));