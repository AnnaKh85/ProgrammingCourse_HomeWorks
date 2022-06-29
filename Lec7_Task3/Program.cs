/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;

Clear();

Write("enter the number of rows: ");
int rows = int.Parse(ReadLine());
Write("enter the number of colums: ");
int cols = int.Parse(ReadLine());

int[,] array = GetArray(cols, rows);

WriteArrayInt(array);

Write($"\nThe average:\n");

for (int i = 0; i < cols; i++)
{
  double arithmetic = 0;
  for (int j = 0; j < rows; j++)
  {
    arithmetic += array[i, j];
  }
  arithmetic = Math.Round(arithmetic / cols, 1);
  WriteLine($"the column № {i+1} {arithmetic}");
}


int[,] GetArray(int cols, int rows)
{ 
    int[,] result = new int[cols, rows];
    for (int i = 0; i < result.GetLength(0); i++)
    {

        for (int j = 0; j < result.GetLength(1); j++)
        {

            result[i, j] = new Random().Next(-10, 10);
        }
    }

    return result;
}

void WriteArrayInt (int[,] array){
for (int i = 0; i < array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(0); j++)
      {
        Write(array[i, j] + " ");
      }
      WriteLine();
  }
}
