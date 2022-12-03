//Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

int Pow(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result*num1;
    }


    return result;
}


Console.WriteLine("Для возведения числа А в степень В: Введите число А:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Для возведения числа А в степень В: Введите число B:");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(A, B));
