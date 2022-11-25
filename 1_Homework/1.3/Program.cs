// Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine("Число четное.");
}
else 
{
    Console.WriteLine("Число не четное");
}
