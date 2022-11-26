// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.


int Method(int num)
{
    Console.WriteLine(num);
    int first = num/10;
    int second = first%10;
    int third = (first - second)+num%10;
    return third;
}

Console.WriteLine(Method(new Random().Next(100,1000)));

