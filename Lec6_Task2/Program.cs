/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
 */

using System;
using static System.Console;

Clear();

Write("Enter b1: ");
int b1 = int.Parse(ReadLine());
Write("Enter k1: ");
int k1 = int.Parse(ReadLine());
Write("Enter b2: ");
int b2 = int.Parse(ReadLine());
Write("Enter k2: ");
int k2 = int.Parse(ReadLine());

pointOfIntersection(b1, k1, b2, k2);


void pointOfIntersection(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    
    if ((k1 * point[0] + b1) == (k2 * point[0] + b2)) {


        Write("Point of intersection: ");
        Write($"[{String.Join(", ", point)}]");
}
else
{
    WriteLine("There is no intersection.");
}


  
}