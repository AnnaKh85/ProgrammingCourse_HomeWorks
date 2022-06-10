/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/

using System;

Console.Clear();

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine("The third number " + numberText[2]);
}
else {
  Console.WriteLine("There is no the third number");
}