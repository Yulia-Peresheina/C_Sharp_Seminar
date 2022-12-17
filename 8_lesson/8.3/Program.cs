// 4. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[,] DeleteRowColumnMinNum(int[,] old, int[] minIndexArr)
{
    int[,] newArr = new int[old.GetLength(0) - 1, old.GetLength(1) - 1];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        int m = i;
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            int n = j;
            if (i == minIndexArr[0])
                m += 1;
            else if (j == minIndexArr[1])
                n += 1;
            if (m == old.GetLength(0) || n == old.GetLength(1))
                return newArr;
            newArr[i, j] = old[m, n];
        }
    }
    return newArr;
}

int[] FindMinInMatrix(int[,] matr)
{
    int[] minIndex = new int[2];
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}
void PrintArray(int[] array)                   //для вывода массива средних арифметических
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
        Console.Write($" {array[i]} ");
    Console.WriteLine();
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
int [] minimum = FindMinInMatrix(matrix);
PrintArray(minimum);
PrintMatrix(DeleteRowColumnMinNum(matrix, minimum));