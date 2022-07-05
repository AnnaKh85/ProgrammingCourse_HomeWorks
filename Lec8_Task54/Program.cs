/*** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
 
Исходный массив:
1 4 7 2
5 9 2 3
8 4 2 4

Результат:
7 4 2 1
9 5 3 2
8 4 4 2
 
 */

using System;
using static System.Console;

Clear();

Write("enter the number of rows: ");
int rows = int.Parse(ReadLine());
Write("enter the number of colums: ");
int cols = int.Parse(ReadLine());

int[,] array = GetArray(cols, rows);

WriteLine("");

printArray(array);

OrderArray(array);

WriteLine("Sorted array: ");

printArray(array);


int[,] GetArray(int cols, int rows) 
{
    int[,] result = new int[cols, rows];
    for (int i = 0; i < result.GetLength(0); i++) { 
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = new Random().Next(0, 100);
        }
    }
    return result; 
}


void OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void printArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (j > 0) {
                Write(", ");
            }
         Write(array[i, j]);
        }
    WriteLine();
    }
}