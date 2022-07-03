/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Исходный массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Результат:
1-строка*/

using System;
using static System.Console;

Clear();

Write("Enter the number of rows: ");
int rows = Convert.ToInt32(ReadLine());

Write("Enter the number of cols: ");
int cols = Convert.ToInt32(ReadLine());

Write("Enter the range: from 1 to ");
int range = Convert.ToInt32(ReadLine());

int[,] array = new int[rows, cols];

CreateArray(array);

WriteArray(array);

int minSumLine = 0;
int sumLine = minSumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = minSumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

WriteLine($"\n{minSumLine+1} - the string with the mininum sum ({sumLine}) of elements");


int minSumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write(array[i,j] + " ");
    }
    WriteLine();
  }
}