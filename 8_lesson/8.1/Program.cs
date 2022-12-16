// 2. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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

 // для транспонирования в ту же самую матрицу квадратных матриц
// void ChangeRowToColumn(int[,] arr)                
// {
//     if (arr.GetLength(0) != arr.GetLength(1))
//     {
//         Console.WriteLine("error");
//         return;
//     }
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < arr.GetLength(1); j++)
//         {
//             (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]); // 1 ,0 0,1  = 0,0 0,1
//         }
//     }
// }


// для транспонирования в новую матрицу любых матриц
int [,] ChangeRowToColumn(int[,] arr)               
{
    int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr2[j,i] = arr[i,j];
        }
    }
    return arr2;
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
int[,] matrix = FillMatrix(4, 3, 1, 9);
PrintMatrix(matrix);
PrintMatrix(ChangeRowToColumn(matrix));
