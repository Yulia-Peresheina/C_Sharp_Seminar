
// Напишите программу, которая принимает на вход любое число
// и проверяет, является ли оно палиндромом.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Palindrom(int number)
{
    if (number > 9)
    {
        //определяем разрядность числа 
        int discharge = 2;
        int num = number;
        while (num > 99)
        {
            num = num / 10;
            discharge++;
        }
        Console.WriteLine(discharge);
        //запускаем проверку на палиндром
        int dis;
        if (discharge % 2 == 0)
            dis = discharge / 2;
        else
            dis = discharge / 2 + 1;
        int undis = 0;
        //цикл выполняется до тех пор, пока не дойдет до середины
        while (discharge > dis)
        {

            if ((Math.Truncate(number / Math.Pow(10, (discharge - 1)) % 10)) == (Math.Round(number / Math.Pow(10, undis) % 10)))
            {
                discharge = discharge - 1;
                undis = undis + 1;
            }
            else
            {
                Console.WriteLine("no ");
                return;
            }
        }

        Console.WriteLine("yes ");
        return;
    }
    Console.WriteLine("no");


}




int N = ReadNumber("Проверка на палиндром. Введите число: ");
Palindrom(N);

// 12321
