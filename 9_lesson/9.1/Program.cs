// Задайте значенияM и N. Напишите программу, которая рекурсивно выведет 
//все натуральные числа в промежутке от M до N.

void PrintNumbsBetw(int M, int N)
{
    if (M < 0 || N < 0) return;
    if (M > N) return;
    Console.Write($"{M} ");
    PrintNumbsBetw(M + 1, N);
}

PrintNumbsBetw(15, 30);