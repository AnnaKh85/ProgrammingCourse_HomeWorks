/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 * и возвращает значение этого элемента или же указание, что такого элемента нет.
 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();

Write("Enter the number of columns: ");
int cols = Convert.ToInt32(ReadLine());
Write("Enter the number of rows: ");
int rows = Convert.ToInt32(ReadLine());

WriteLine(" ");

int[,] array = new int[cols, rows];

CreateArray(array);

WriteArray(array);

WriteLine();

void CreateArray(int[,] array)
{
  for (int i = 0; i < cols; i++)
  {
    for (int j = 0; j < rows; j++)
    {
      array[i, j] = new Random().Next(-10, 10);
    }
  }
}

void WriteArray (int[,] array){
for (int i = 0; i < cols; i++)
  {
      for (int j = 0; j < rows; j++)
      {
        int alignNumber = array[i, j];
        Write(alignNumber + " ");
      }
      WriteLine();
  }
}

Write("Enter the coordinates of the position (separated with comma (,)): ");

string positionElement = ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= cols 
&& position[1] <= rows 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  int result = array[position[0]-1, position[1]-1];
  Write($"Element: {result}");
}
else Write($"There is no that element in the array.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}