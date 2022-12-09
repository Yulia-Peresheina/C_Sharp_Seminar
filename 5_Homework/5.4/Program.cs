// Требуется написать программу, производящую, согласно утверждению 
// Гольдбаха, разложение заданного четнрого числа.
// Из всех пар простых чиселб сумма которых равна заданному числу, 
// требуется найти пару, содержащую наименьшее простое число.


bool isPrime(int N)
{
    for( int i = 2; i < N; i=i+1)
    {
        if (N%i ==0)
            return false;
    }
    return true;
}

void Method2(int num)
{
    if (num % 2 != 0)
        return;
    int first = 2;
    int second = num - first;
    if (isPrime(second))
        Console.WriteLine($"Cумма простых чисел для числа {num}: {first} + {second}");
    else
    {
        for (first = 3; first < num / 2; first++)
        {
            if (isPrime(first))
            {
                second = num - first;
                if (isPrime(second))
                {
                    Console.WriteLine($"Cумма простых чисел для числа {num}: {first} + {second}");
                    return;
                }
            }
        }
    }
}
Console.Write("Введите четное число от 4 до 998: ");
int Number = int.Parse(Console.ReadLine()!);
Method2(Number);

