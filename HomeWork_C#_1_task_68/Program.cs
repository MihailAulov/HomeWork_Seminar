﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// 
// m = 2, n = 3 -> A(m,n) = 9
// 
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

long AckermannFunction(long m, long n)
{
    if (m > 0)
    {
        if (n > 0)
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
    }
    else if (m == 0 && n >= 0)
    {
        return n + 1;
    }
    throw new System.ArgumentOutOfRangeException();
}
Console.WriteLine(AckermannFunction(m, n));