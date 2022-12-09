// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.


bool Teorema(int a, int b, int c)
{
    if (a + b > c && c + a > b && c + b > a)
        return true;
    else
        return false;
}

Console.WriteLine(Teorema(1, 1, 5));