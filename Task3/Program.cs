// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] matrix)
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            if (i%2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j%2 == 0)
                    matrix[i,j] = matrix[i,j]*matrix[i,j];
                }
            }    
    }
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine()?? "0");

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine("");
Change(matrix);
Console.WriteLine("Измененный массив:");
PrintArray(matrix);


