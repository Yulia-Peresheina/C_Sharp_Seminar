// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

Int128 Composition (int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result*i;
        
    }
    return result;

}
Console.WriteLine(Composition(int.Parse(Console.ReadLine())));