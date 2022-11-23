// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());


if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("Максимальное число "+ num1);
    }
    else if (num1 < num3)
    {
        Console.WriteLine("Максимальное число "+ num3);
    }
    else 
    {
        Console.WriteLine("Первое и третье число являются одинаковыми и максимальными: "+ num3);
    }
}
    
else if (num1 < num2)
{
    if (num3 > num2)
    {
        Console.WriteLine("Максимальное число "+ num3);
    }
    else if (num3 < num2)
    {
        Console.WriteLine("Максимальное число "+ num2);
    }
    else 
    {
        Console.WriteLine("Второе и третье число одинаковы и являются максимальными: "+ num3);
    }
}
else if (num1 == num2)
{
    if(num1 == num3)
    {
        Console.WriteLine("Все числа равны");
    }
    else if (num1 > num3)
    {
        Console.WriteLine("Первое и второе число одинаковы и являются максимальными: "+ num2);
    }
    else
    {
        Console.WriteLine("Максимальное число "+ num3);
    }

}




