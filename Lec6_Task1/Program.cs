/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System;
using static System.Console;

Clear();

Write("Enter elements of array: ");
int[] array = getArray(ReadLine());
Write($"[{String.Join(", ", array)}]");
WriteLine($" -> {countSumOfPositiveNum(array, array.Length)}");

int[] getArray(string arrStr) {

    string[] arr = arrStr.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arr.Length];
    for(int i=0; i < arr.Length; i++) {
        result[i] = int.Parse(arr[i]); 
     }

    return result;
}

int countSumOfPositiveNum(int[] array, int size)
{
    int result = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }

    return result;
}