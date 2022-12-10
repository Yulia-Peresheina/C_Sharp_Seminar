// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

string PointIntersection(double b1, double k1, double b2, double k2)
{
    //Решаем систему уравнений
    // y = k1 * x + b1;
    // y = k2 * x + b2;
    // k1* x + b1 = k2 * x + b2;
    // k1* x - k2 * x = b2 - b1
    // x(k1 - k2) = b2 - b1
    double x = Math.Round((b2 - b1)/(k1 - k2), 2);
    double y = Math.Round(k1*((b2 - b1)/(k1 - k2)) + b1, 2);
    return $"Координаты точки пересения двух прямых: ({x}, {y}).";
}

Console.WriteLine("Будет вычислена точка пересечения прямых, заданных уравнением y = k*x + b. ");
Console.Write("Введите переменную k первой прямой: ");
double a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите переменную b первой прямой: ");
double n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите переменную k второй прямой: ");
double a2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите переменную b второй прямой: ");
double n2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PointIntersection(a1, n1, a2, n2));