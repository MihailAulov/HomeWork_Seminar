﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"

// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите целые числа N: ");
int N = Convert.ToInt32(Console.ReadLine());


int RecMethod(int N)
{   
    Console.Write($"{N}");
    if(N > 2) {
        Console.Write(", ");
        RecMethod(N-1);
    }
    else Console.Write(", ");
    if (N <= 1) return 0;
    return 1;
}

Console.Write('"');
Console.Write(RecMethod(N));
Console.WriteLine('"');