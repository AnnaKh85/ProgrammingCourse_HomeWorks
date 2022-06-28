/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

using System;
using static System.Console;

Clear();


Write("enter the number of rows: ");
int rows = int.Parse(ReadLine());
Write("enter the number of colums: ");
int cols = int.Parse(ReadLine());

double[,] ar = GetRandomArray(rows, cols);
PrintArray(ar);

double[,] GetRandomArray(int row, int cols)
{

    double[,] result = new double[rows, cols];
    for (int i = 0; i < result.GetLength(0); i++)
    {

        for (int j = 0; j < result.GetLength(1); j++)
        {

            result[i, j] = new Random().NextDouble();
        }
    }

    return result;
}

void PrintArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{Math.Round(array[i, j], 2)}");
        }
        WriteLine();
    }

}
