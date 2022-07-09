/*
Задача 61: Показать треугольник Паскаля. 
Сделать вывод в виде равнобедренного треугольника.
 */

using System;
using static System.Console;

Clear();

int i, c;
Write("Enter the number of rows: ");
string s = ReadLine();
int n = Convert.ToInt32(s);

int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++)
    {
        Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Write(" "); 
        Write(factorial(i) / (factorial(c) * factorial(i - c))); 
    }
    WriteLine();
}
