/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

using System;

Console.Clear();


Console.Write("Enter the first number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

if ((Num1 > Num2) && (Num1 > Num3)) {
    Console.WriteLine("Num1");
}
else if ((Num2 > Num1) && (Num2 > Num3)) {
       Console.WriteLine("Num2"); 
}
else if ((Num3 > Num1) && (Num3 > Num2)) {
    Console.WriteLine("Num3");
}
