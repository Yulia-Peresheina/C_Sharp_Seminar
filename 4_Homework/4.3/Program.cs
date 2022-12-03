//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.


double[] CreateArray(int count)
{
    double[] array = new double [count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}


void PrintArray(double [] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите количество элементов создаваемого массива: ");
int N = int.Parse(Console.ReadLine());
PrintArray(CreateArray(N));