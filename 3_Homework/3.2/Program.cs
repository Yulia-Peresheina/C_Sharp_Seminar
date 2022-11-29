// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double dis = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return dis;

}

int xa = ReadNumber("Введите координату Xa: ");
int ya = ReadNumber("Введите координату Ya: ");
int za = ReadNumber("Введите координату Za: ");
int xb = ReadNumber("Введите координату Xb: ");
int yb = ReadNumber("Введите координату Yb: ");
int zb = ReadNumber("Введите координату Zb: ");

Console.WriteLine(Math.Round(Distance(xa,ya,za,xb,yb,zb),2));
