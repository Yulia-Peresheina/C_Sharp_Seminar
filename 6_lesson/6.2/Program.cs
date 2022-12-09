// 2. Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string DecDvoich(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result = (num%2).ToString()+result;
        num=num/2;
    }
    return result;
}

Console.WriteLine(DecDvoich(45));
