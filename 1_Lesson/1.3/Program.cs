// напишите программу, которая на вход принимате одно число N,
// а на выходе дает все целые числа в промежутке от -N до N


Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    
    for (int i = -N; i < (N + 1); i++)
    {
        Console.Write(i + " ");
    }

}
else if (N < 0)
{
    
    for (int i = N; i < (-N + 1); i++)
    {
        Console.Write(i +" ");
    }
}
else 
{
    Console.WriteLine("0");
}