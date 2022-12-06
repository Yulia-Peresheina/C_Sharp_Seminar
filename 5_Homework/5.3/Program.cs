// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int count, int upbound, int lowbound)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * (upbound - lowbound) + lowbound), 2);
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

double MaxMinDif(double[] array)
{
    double result;
    double max, min;
    if (array[0] > array[1])
    {
        max = array[0];
        min = array[1];
    }
    else
    {
        max = array[1];
        min = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    result = max - min;
    return result;
}

Console.Write("Введите количество элементов создаваемого массива вещественных чисел: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу массива: ");
int lowbound = int.Parse(Console.ReadLine()!);
Console.Write("Введите верхнюю границу массива: ");
int upbound = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(N, upbound, lowbound);
PrintArray(array);
Console.WriteLine($"Разница между минимальным и максимальным значением массива равна: {MaxMinDif(array)}");
