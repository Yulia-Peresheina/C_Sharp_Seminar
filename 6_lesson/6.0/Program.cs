// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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
// способ 1 через новый массив
// int [] Revert (int [] arr)
// {
//     int [] mas = new int[arr.Length];
//     int j = mas.Length - 1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         mas[j] = arr[i];
//         j-=1;
//     }
//     return mas;
// }
 //способ 2 изменение того же массива через переменную
// int[] RevMas(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
//     return arr;
// }

// способ 3 через замену кортежами

int [] RevMas(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
    }
    return arr;
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимально возможный элемент массива: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимально возможный элемент массива: ");
int to = int.Parse(Console.ReadLine()!);

int[] array = CreateArray(N, from, to);
PrintArray(array);

// int[] massiv = Revert(array);
// PrintArray(massiv);

array = RevMas(array);
PrintArray(array);