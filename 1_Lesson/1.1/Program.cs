// Написать программу, которая на вход принимает 2 числа 
// и проверяет, является ли первое число квадратом второго


Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Первое число - квадрат второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}