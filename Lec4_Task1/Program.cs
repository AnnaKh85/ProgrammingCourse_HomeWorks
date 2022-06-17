/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

using System;
using static System.Console;

Clear();
Write("Enter the number: ");
double N = Convert.ToDouble(Console.ReadLine());
Write("Enter the power of the number: ");
double P = Convert.ToDouble(Console.ReadLine());

double sum = PowOfNum(N, P);
WriteLine($"Result: {sum}");

double PowOfNum(double A, double B)
{
    double result = 0;

    result = Math.Pow(A, B);

    return result;
}