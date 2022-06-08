/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

using System;
using static System.Console;

Console.Clear();

Console.Write("Enter the first number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 < Num2) {
   Console.WriteLine("The first number is less than the second one");
}
else 
Console.WriteLine("The second number is less than the first one");
