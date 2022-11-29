// 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.


int ReadNumber (string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = (s == null) ? 0 : int.Parse(s);
    return a;

}

double Distance (double xa, double ya, double xb, double yb)
{
    double dis = Math.Sqrt((Math.Pow((xb - xa), 2)) + Math.Pow((yb - ya), 2 ));
    return dis;
}


int xa = ReadNumber("Введите Ха: ");
int ya = ReadNumber("Введите Yа: ");
int xb = ReadNumber("Введите Хb: ");
int yb = ReadNumber("Введите Yb: ");

// Console.WriteLine("Введите ха: ");
// int xa = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите хb: ");
// int xb = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите yа: ");
// int ya = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите yb: ");
// int yb = int.Parse(Console.ReadLine());


Console.WriteLine(Math.Round(Distance(xa,ya,xb,yb),2));



