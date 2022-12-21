// Напишите программу, которая на вход принимает 2 числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.

int Power(int A, int B)
{
    if (B == 0) return 1;
    int result = A * Power(A, B - 1);
    return result;
}

Console.WriteLine(Power(2, 3));