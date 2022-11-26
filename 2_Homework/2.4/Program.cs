// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string WeekDay(int num)
{
    if ((num < 8 && num > 0) && (num == 6 || num == 7))
        return "Этот день выходной";
    else if (num < 8 && num > 0)
        return "Этот день рабочий";
    else
        return "Ошибка";

}
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine(WeekDay(num));



Console.WriteLine("Введите число от 1 до 7: ");
Console.WriteLine(WeekDay(int.Parse(Console.ReadLine())));