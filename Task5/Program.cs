// В матрице чисел найти сумму элементов главной диагонали
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

int MainDiagSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + matrix[i, j];
        }
    }
    return sum;
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
int mainSum = MainDiagSum(matrix);
Console.WriteLine($"Сумма главной диагонали массива равна: {mainSum}");





