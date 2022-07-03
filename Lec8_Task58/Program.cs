/*
 **Задача 58:** Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
 */

using System;
using static System.Console;

Clear();

Write("Enter the number of rows of the first array: ");
int rows = Convert.ToInt32(ReadLine());

Write("Enter the number of cols of the first (= rows of the second array) array: ");
int cols = Convert.ToInt32(ReadLine());

Write("Enther the number of cols of the second array: ");
int cols2 = Convert.ToInt32(ReadLine());

Write("Enter the range: from 1 to ");
int range = Convert.ToInt32(ReadLine());

int[,] firstArray = new int[rows, cols];
CreateArray(firstArray);
WriteLine($"\nThe first array:");
WriteArray(firstArray);

int[,] secondArray = new int[cols, cols2];
CreateArray(secondArray);
WriteLine($"\nThe second array:");
WriteArray(secondArray);

int[,] resultArray = new int[cols,cols2];

MultiplyArrays(firstArray, secondArray, resultArray);
WriteLine($"\nThe multiplication of the first and second arrays:");
WriteArray(resultArray);

void MultiplyArrays(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
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