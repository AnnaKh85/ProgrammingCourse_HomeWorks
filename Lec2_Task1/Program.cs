/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

using System;

Console.Clear();

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 10 > 0) && (number / 100 == 0)){
    Console.WriteLine("Enter the  correct number!");
}
else {
number = number / 10;
number = number % 10;
Console.WriteLine(number);
}
