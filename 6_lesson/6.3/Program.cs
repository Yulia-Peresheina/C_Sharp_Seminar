// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// int[] Fibon(int predel)
// {
//     int[] arr = new int [predel];
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i-1]+arr[i-1-1];  
//     } 
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     int n = array.Length;
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("сколько элементов должно быть в последовательности фибоначчи?");
// int n = int.Parse(Console.ReadLine()!);
// int[] fibonacci = Fibon(n);
// PrintArray(fibonacci);

//Вариант 2, через кортеж

void Fibonacci(int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

int number = int.Parse(Console.ReadLine());
Fibonacci(number);