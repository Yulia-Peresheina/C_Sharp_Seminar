//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int SecNum(int num)
{
    Console.WriteLine(num);
    return (num/10)%10;
}

Console.WriteLine(SecNum(new Random().Next(100,1000)));