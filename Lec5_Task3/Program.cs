/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 [3 7 22 2 78] -> 76 */

using System;
using static System.Console;

Clear();

Write("Enter elements of array: ");
int[] array = getArray(ReadLine());
Write($"[{String.Join(", ", array)}]");
WriteLine($" -> {sumOfElements(array, array.Length)}");

int[] getArray(string arrStr) {

    string[] arr = arrStr.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arr.Length];
    for(int i=0; i < arr.Length; i++) {
        result[i] = int.Parse(arr[i]); 
     }

    return result;
}

int sumOfElements(int[] array, int arraySize)
{
    int sum = 0;

    for(int i=0; i < arraySize; i++)
    {
        if (i % 2 != 0) {
            sum = array[i] + sum;
        }
    }

    return sum;
}