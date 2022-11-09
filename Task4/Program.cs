﻿// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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

void FindPos(int[,] matrix, int num)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                count++;
                Console.WriteLine($"Искомое число {num} встречается {count}-й раз в {i + 1} строке и {j + 1} столбце");
                    
            }

        }
    }
    if (count<1)
        Console.WriteLine($"Искомое число {num} в массиве не содержится");
}


Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine()?? "0");

int[,] matrix = new int[m, n];
Console.WriteLine("Введите число для поиска в массиве:");
int num = int.Parse(Console.ReadLine()?? "0");

FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine("");
FindPos(matrix, num);




