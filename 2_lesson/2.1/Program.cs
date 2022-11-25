// 1. Напишите программу, которая выводит случайное трёхзначное число
// и на выходе показывает последнюю цифру этого числа.


int LastNumber(int num)
{
    Console.WriteLine(num);
    return num%10;
}

Console.WriteLine(LastNumber(new Random().Next(100,1000)));