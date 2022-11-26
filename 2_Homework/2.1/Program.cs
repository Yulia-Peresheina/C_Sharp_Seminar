//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

string SecNum(int num)
{
    if (num > 99 && num <1000)
    {
        
        return "вторая цифра "+(num/10)%10;
    }
    else
    {
        return "Ошибка. Введите ТРЕХЗНАЧНОЕ число.";
        
    
    }
}

// Для случайного трехзначного числа
// Console.WriteLine(SecNum(new Random().Next(100,1000)));


Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SecNum(number));