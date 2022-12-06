// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

double[] CreateArray(int count, int from, int to)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}


void PrintArray(double[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumArr(double[] array)
{
    double SumPos, SumNeg;
    SumPos = SumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            SumPos += array[i];
        else
            SumNeg += array[i];

    }
    Console.WriteLine(SumPos);
    Console.WriteLine(SumNeg);
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine());

double[] array = (CreateArray(N, from, to));

PrintArray(array);

SumArr(array);