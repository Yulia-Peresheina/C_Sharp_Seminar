// Написать программу вычисления модуля числа


Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

if (N >= 0)
{
    Console.WriteLine("Модуль числа равен " + N);
}
else
{
    Console.WriteLine("Модуль числа равен " + (-N));
}

// Альтернативный вариант
// Console.Write("Введите число:");
//var s = Console.ReadLine();
//int N = s == null ? 0 : int.Parse(s);
//Console.WriteLine($"{Math.Abs(N)}");