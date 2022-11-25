// 4. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

string Multiple23and7(int num)
{
    if (num%7 == 0 && num%23 ==0)
        return "Multiple";
   
    else
        return "not multiple";
}

System.Console.WriteLine(Multiple23and7(49));