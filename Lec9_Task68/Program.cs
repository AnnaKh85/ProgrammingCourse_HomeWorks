/*
 **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
 */

using System;
using static System.Console;

Clear();

Write("Enter M: ");
int m = Convert.ToInt32(ReadLine());

Write("Enter N: ");
int n = Convert.ToInt32(ReadLine());


int functionAkkerman = Akk(m, n);

Write($"A({m}, {n}) = {functionAkkerman} ");


int Akk(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return Akk(n - 1, 1);
                if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
                return Akk(n,m);
            }



