﻿// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
//
// M = 1; N = 15 -> 120
//
// M = 4; N = 8. -> 30

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());


int NaturalSummaRangeMethodRecursion(int M, int N, int value = 0)
{
    if(M <= N)
    {
        return NaturalSummaRangeMethodRecursion(M+1,N,value+M);
    }
    return value;
}

int value = NaturalSummaRangeMethodRecursion(M, N);
Console.WriteLine($"Сумма натуральных чисел в диапазоне между {M} и {N}, составляет: {value}");