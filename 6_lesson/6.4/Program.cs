// 4. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[,] CreateMatrix(int row, int col)
{
    int[,] mat = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            mat[i,j] = new Random().Next(0, 100);
        }
    }
    return mat;
}

void PrintMatrix(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m,n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CopyMatrix(int[,] matr)
{
    int[,] copymatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            copymatr[i,j] = matr[i,j];
        }
    }
    return copymatr;
}

int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);

int [,] matrix = CreateMatrix(rows, columns);
PrintMatrix(matrix);

int[,] copy = CopyMatrix(matrix);
PrintMatrix(copy);
