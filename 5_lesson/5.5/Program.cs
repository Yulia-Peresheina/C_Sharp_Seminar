// Найдите произведение пар чисел в одномерном массиве
//парой считаем первый и последний элемент массива, второй и предпоследний, и т.д.
// результат запишите в новом массиве


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

double[] MultiplicationArr(double[] array)
{
    int length = array.Length / 2 + array.Length % 2;
    double[] array2 = new double[length];
    for (int i = 0; i <= array.Length / 2; i++)
    {
        array2[i] = array[i] * array[(array.Length - 1) - i];
    }
    if (array.Length % 2 != 0)
        array2[length - 1] = array[array.Length / 2];
        return array2;
    return array2;
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(N, from, to);
PrintArray(array);

double[] array2 = MultiplicationArr(array);
PrintArray(array2);