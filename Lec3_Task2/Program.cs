/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

using System;
using static System.Console;

Clear();

Write("Enter x1: ");
int x1 = int.Parse(ReadLine());
Write("Enter y1: ");
int y1 = int.Parse(ReadLine());
Write("Enter z1: ");
int z1 = int.Parse(ReadLine());
Write("Enter x2: ");
int x2 = int.Parse(ReadLine());
Write("Enter y2: ");
int y2 = int.Parse(ReadLine());
Write("Enter z2: ");
int z2 = int.Parse(ReadLine());

int X = x1 - x2;
int Y = y1 - y2;
int Z = z1 - z2;

double range = Math.Round(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)), 2);
WriteLine($"Result: {range}");