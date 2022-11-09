// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = m + n;
        }
    }
}

 void PrintArray(int [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++) 
    {
        for (int n = 0; n < array.GetLength(1); n++) 
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "0");
int [,] array = new int [m,n];

FillArray(array);
Console.WriteLine("Полученный двумерный массив по правилу m+n :");
PrintArray(array);
