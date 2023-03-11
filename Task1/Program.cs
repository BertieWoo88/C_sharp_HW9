/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using System;
using static System.Console;

Clear();
int n = asknum("значение N");
WriteLine(Numdown(n));

int asknum(string name)
{
    Write($"Введите {name}: ");
    int n = int.Parse(ReadLine()!);
    return n;
}

string Numdown(int n)
{
    if (n==1) return n.ToString() + ".";
    return  n.ToString() + ", " + Numdown(n-1);

} 

