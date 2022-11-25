// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void Multiple(int num1, int num2)
{
    if (num1%num2 ==0)
    {
        Console.WriteLine("Multiple");
    }
      
    else
    {
        Console.WriteLine($"Not multiple, remainder {num1%num2}");
    }
}

Multiple(34, 5);


//Другой вариант
// string crat(int num,int num2)
// {
// if (num % num2 == 0)
// return "кратно";
// else
// return $"некратно, остаток = {num % num2}";
// }
// Console.WriteLine("1 chislo");
// int first = int.Parse(Console.ReadLine());
// Console.WriteLine("2 chislo");
// int second = int.Parse(Console.ReadLine());
// Console.WriteLine(crat(first, second));