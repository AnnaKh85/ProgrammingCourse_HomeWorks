/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

using System;
using static System.Console;

Clear();

Write("Enter the number: ");
int num = int.Parse(ReadLine());

for (int i = 1; i <= num; i++)
{
    WriteLine(Math.Pow(i, 3));
}