// 3. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

void Array(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");
        
    }
    
}
 

Array(8);