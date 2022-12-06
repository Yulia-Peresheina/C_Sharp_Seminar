//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int count, int from, int to)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumNotEven(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result = result + array[i];
    return result;
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine()!);

int[] array = CreateArray(N, from, to);
PrintArray(array);
Console.WriteLine($"Сумма значений нечетных индексов массива равна {SumNotEven(array)}");