// 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = (s == null) ? 0 : int.Parse(s);
    return a;

}



void SqrtNum(int num)
{
   int i = 1;
   while (i < (num + 1))
   {
        Console.Write(Math.Pow(i, 2)+" ");
        i++;
   }
   return;

}

int N = ReadNumber("Введите число: ");
SqrtNum(N);