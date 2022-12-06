// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int FindQuantity(double[] array, int start, int finish)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= finish)
            quantity+=1;
    }
    return quantity;
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число промежутка поиска: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число промежутка поиска: ");
int finish = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(N, from, to);
PrintArray(array);
Console.WriteLine($"Количество элементов из заданного промежутка: {FindQuantity(array, start, finish)}");