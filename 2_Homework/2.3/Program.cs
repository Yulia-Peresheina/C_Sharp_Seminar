// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void Method(int num)
{
    if (num > 100)
    {
        while (num > 999)
            num = num / 10;
        Console.WriteLine($"Третья цифра {num % 10}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

Console.WriteLine("Введите число");


Method(int.Parse(Console.ReadLine()));