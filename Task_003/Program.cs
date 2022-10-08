/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitRandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetSimpleAverage(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++; ;
        }
        Console.WriteLine($"Среднее арифметическое столбца {j + 1}: " + (double)sum / count);
    }
}

int n = GetNumber("Введите кол-во строк:");
int m = GetNumber("Введите кол-во столбцов:");
Console.WriteLine();

int[,] matrix = InitRandomMatrix(n, m);
PrintMatrix(matrix);
Console.WriteLine();

GetSimpleAverage(matrix);