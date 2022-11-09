// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов
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
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double [] SummColumns(int[,] matrix)
{
    double[] SumMatrix = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            SumMatrix[j] = sum / matrix.GetLength(1);
        }
    }
    return SumMatrix;
}

void PrintNewArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]}    ");
    }
}

Console.WriteLine("Введите количество строк двухмерного массива:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов двухмерного массива:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($" Исходный массив :");

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца в массиве: ");
double [] NewMatrix = SummColumns(matrix);
PrintNewArray(NewMatrix);