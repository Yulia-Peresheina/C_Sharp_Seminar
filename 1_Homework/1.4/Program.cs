// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

if (num <= 1)
{
    Console.WriteLine("Нет четных положительных чисел в промежутке от "+num+" до 1");
}

else
    if (num%2 == 0)
    {
        int count = num;
        while (count >= 1)
        {
            Console.Write(count+" ");
            count=count - 2;
        }
    }
    else
    {
        int count = num - 1;
        while (count >= 1)
        {
            Console.Write(count+" ");
            count=count - 2;
        }
    }

    //вариант преподавателя:

    // int i = 2;
    // while (i < num)
    //{
//      Console.Write(i);
//      i+=2;
    //}