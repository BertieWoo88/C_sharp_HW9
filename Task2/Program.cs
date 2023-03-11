/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;

Clear();
int m = asknum("значение M");
int n = asknum("значение N");
WriteLine($"M = {m}; N = {n} -> {SumElements(n, m)}");

int asknum(string name)
{
    Write($"Введите {name}: ");
    int n = int.Parse(ReadLine()!);
    return n;
}

int SumElements(int m, int n)
{
    if (m==n) return m;
    return  m + SumElements(m-1, n);

} 
