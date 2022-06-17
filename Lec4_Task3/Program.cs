/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

using System;
using static System.Console;

Clear();

Write("Enter the size of array: ");
int N = Convert.ToInt32(Console.ReadLine());
printArray(N);

void printArray(int size)
{
    int[] arr = new int[size];
    WriteLine("Enter the elements of array: ");
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Write("[");
    for (int i = 0; i < size-1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length-1]}]");
}