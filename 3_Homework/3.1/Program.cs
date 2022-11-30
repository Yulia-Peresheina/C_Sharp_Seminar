//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

string Palindrom(int num)
{
    if (num > 9999 && num < 99999)
    {    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10)) return " -> yes";
        return " -> no";
    }
    return "error";
}




int N = ReadNumber("Проверка на палиндром. Введите пятизначное число: ");
Console.WriteLine(Palindrom(N));




