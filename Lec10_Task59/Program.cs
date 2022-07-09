/*
 Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
 */

using System;
using static System.Console;

Clear();

Write("Enter the number of rows: ");
int rows = Convert.ToInt32(ReadLine());

Write("Enther the number of cols: ");
int cols = Convert.ToInt32(ReadLine());

Write("Enter the range: from 1 to ");
int range = Convert.ToInt32(ReadLine());


int[,] array = new int[rows, cols];
CreateArray(array);
WriteArray(array);


int[,] positionSmallElement = new int[1, 2];
positionSmallElement = FindPosition(array, positionSmallElement);
Console.Write($"Position of small element: \n");
WriteArray(positionSmallElement);


int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, positionSmallElement, arrayWithoutLines);
Console.WriteLine($"\nResult: ");
WriteArray(arrayWithoutLines);


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FindPosition(int[,] array, int[,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = array[i, j];
            }
        }
    }
    Console.WriteLine($"\nThe smallest element is : {temp}");
    return position;
}

void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
    int m = 0, n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
            {
                arrayWithoutLines[m, n] = array[i, j];
                n++;
            }
        }
        n = 0;
        if (positionSmallElement[0, 0] != i)
        {
            m++;
        }
    }
}