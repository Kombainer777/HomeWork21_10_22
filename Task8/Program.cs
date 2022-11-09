// В прямоугольной матрице найти строку с наименьшей суммой элементов
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

int CheckSum(int[,] array)
{
    int index = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0) 
            min = sum;
        else if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    return index;
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("");

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Полученный массив:");
PrintArray(matrix);
int x = CheckSum(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {x+1}");

