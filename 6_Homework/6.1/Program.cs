﻿// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Vvod()
{
    Console.Write("Введите число: ");
    string num = Console.ReadLine()!;
    int count = 0;
    while (num != "")
    {
        int snum = int.Parse(num);
        if (snum > 0)
            count += 1;
        Console.Write("Введите число: ");
        num = Console.ReadLine()!;
    }
    return count;
}

Console.WriteLine($"Вы ввели {Vvod()} чисел больше 0.");


// Вариант не работает. Почему?
// int Vvod()
// {
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine()!);
//     int count = 0;
//     while((Convert.ToString(num)) != "")
//     {
//         if (num > 0)
//             count += 1;
//         Console.Write("Введите число: ");
//         num = int.Parse(Console.ReadLine()!);
//     }
//     return count;
// }

// Console.WriteLine($"Вы ввели {Vvod()} чисел больше 0.");