// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string WeekDay(int num)
{
    if (num == 6 || num == 7)
        return "Этот день выходной";
    else if (num < 8 && num > 0)
        return "Этот день рабочий";
    else
        return "Ошибка";

}




Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели, где 1 - это понедельник, а 7 - это воскресенье: ");
Console.WriteLine(WeekDay(int.Parse(Console.ReadLine())));


//альтернатива:



// string WeekDay(int num)
// {
//     string text = "no";
//     if ( num == 6|| num == 7) text = "yes";
//     return text;
// }
// Console.WriteLine(WeekDay(int.Parse(Console.ReadLine())));