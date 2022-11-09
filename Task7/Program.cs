// Написать программу, которая обменивает элементы первой строки и последней строки
void FillArray(int[,] matrix, int m)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);   
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

void Change(int[,] matrix)
{
    int temp = 0;
    int i = 0;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i,j];
                matrix [i,j] = matrix[matrix.GetLength(0)-1, j];
                matrix [matrix.GetLength(0)-1, j] = temp;
            }
    }
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];

FillArray(matrix, m);
PrintArray(matrix);
Console.WriteLine("");
Change(matrix);
PrintArray(matrix);
