// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.



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

string Find(double[] array, int findnum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (findnum == array[i])
            return "yes";
    }
    return "no";

}


Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для поиска: ");
int findnum = int.Parse(Console.ReadLine()!);

double[] array = CreateArray(N, from, to);
PrintArray(array);
Console.WriteLine($"Результат поиска числа: {Find(array, findnum)}");