/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

using System;
using static System.Console;

Clear();

Write("Enter the number: ");
string num = ReadLine();
int number;
bool isNum = int.TryParse(num, out number);

if (num.Length > 5)
{
    WriteLine("It's not a 5-symbol number.");
}
else {
    if (isNum) {
        if ((num[0] == num[4]) && (num[1] == num[3])) {
             WriteLine("The number is polindrom");
        }
        else {
            WriteLine("The number is NOT polindrom");
        }
    }
    else
    {
        WriteLine("Enter the number!");
    }
}