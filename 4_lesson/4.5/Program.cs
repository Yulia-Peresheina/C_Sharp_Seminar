// Дана последовательность из N целых чисел и число К. 
//Необходимо сдвинуть всю последовательность (сдвиг - цикличкеский)
// на К элементов вправо, если К - положительное, и влево - если отрицательное

void PrintArray(double[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] CreateArray(int count)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

double[] Method(int N, double[] array, int K)
{
    if (K >= 0)
    {
        while (K >= N)
        {
            K = K - N;
        }
        if (K == 0)
        {
            return array;
        }
        else
        {
            int j = 0;
            Double[] mass = new double[N];
            for (int i = 0; i < N; i++)
            {
                j = i + K;
                if (j >= N)
                {
                    j = j - N;
                }
                mass[j] = array[i];
            }
            return mass;
        }
    }
    else
    {
        K = Math.Abs(K);
        while (K >= N)
        {
            K = K - N;
        }
        if (K == 0)
        {
            return array;
        }
        else
        {
            int j = 0;
            Double[] mass = new double[N];
            for (int i = N - 1; i >= 0; i--)
            {
                j = i - K;
                if (j < 0)
                {
                    j = N + j;
                }
                mass[j] = array[i];
            }
            return mass;
        }
    }
}

double[] array = (CreateArray(9));
PrintArray(array);
Console.WriteLine();
double[] array2 = Method(9, array, 9);
PrintArray(array2);
