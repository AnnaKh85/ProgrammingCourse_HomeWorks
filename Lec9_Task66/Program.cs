/*
 **Задача 66:** Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

using System;
using static System.Console;

Clear();

Write("Enter M: ");
int m = Convert.ToInt32(ReadLine());

Write("Enter N: ");
int n = Convert.ToInt32(ReadLine());
int temp = m;

if (m > n) 
{
    m = n; 
    n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Write($"Result = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
