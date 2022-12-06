// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SunNum(int number)
// {
//     int result = 0;
//     number = Math.Abs(number);
//     while (number > 0)
//     {
//         result = result + number % 10;
//         number = number / 10;
//     }
//     return result;
// }


// Console.WriteLine("Введите число, сумму цифр которого хотите сосчитать:");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(SunNum(N));


double SunNum(int number)
{
    string n = number.ToString();
    int length = n.Length;
    double sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + char.GetNumericValue(n[i]);
    }

    return sum;
}
Console.WriteLine("Введите число, сумму цифр которого хотите сосчитать:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(SunNum(N));