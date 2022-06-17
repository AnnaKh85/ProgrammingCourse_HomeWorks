/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

using System;
using static System.Console;

Clear();
Write("Enter the number: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumNums(N);
WriteLine($"Sum of numbers: {sum}");


int SumNums(int num)
{
    int result = 0;

    while(num != 0)
    {
        result += num%10;
        num /=10;
    }

    return result;
}