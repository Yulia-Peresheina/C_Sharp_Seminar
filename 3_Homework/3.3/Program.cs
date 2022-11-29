// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Method(int num)
{
    if (num >= 1)
    {
        int i = 1;
        while (i <= num)
        {
            Console.Write(Math.Pow(i, 3) + " ");
            i++;
        }
        return;
    }
    Console.WriteLine("error");
   
}

int N = ReadNumber("Введите число: ");

Method(N);