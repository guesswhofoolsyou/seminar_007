/* Напишите программу, которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
            matrix[i, j] = rnd.Next(-9, 10);
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

void FindNumber(int[,] matrix, int num)
{
    bool temp = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                Console.Write(i + "," + j + " ");
                temp = true;
            }
        }
    }
    if (temp == false)
        Console.WriteLine(num + " - такого число нет в матрице");
}

int n = GetNumber("Введите кол-во строк:");
int m = GetNumber("Введите колво столбцов:");
int num = GetNumber("Введите искомое число");
Console.WriteLine();

int[,] matrix = InitRandomMatrix(n, m);
PrintMatrix(matrix);
Console.WriteLine();


FindNumber(matrix, num);