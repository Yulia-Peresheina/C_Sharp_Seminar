// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

 double[] ChangeArr(double[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
 }
Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine());

double [] array = CreateArray(N, from, to);
PrintArray(array);
PrintArray(ChangeArr(array));
