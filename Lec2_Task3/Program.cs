/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

using System;

Console.Clear();

Console.Write("Enter the number the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( 
    number == 1 ? "Monday" 
    :number == 2 ? "Thursday"
    :number == 3 ? "Wednesday"
    :number == 4 ? "Thursday"
    :number == 5 ? "Friday"
    :number == 6 ? "Saturday is a weekend! "
    :number == 7 ? "Sunday is a weekend!"
    :"Not a day of the week! ");
