﻿// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayGeneratorNumber(int count, int min, int max)
{
    int[] arrayList = new int[count];
    for (int i = 0; i < count; i++)
       arrayList[i] = new Random().Next(min, max);
    return arrayList;
}

int[] arrayList = ArrayGeneratorNumber(34, 100, 1000);

int countChetnihChisel = 0;
for (int i = 0; i < arrayList.Length; i++)
    if(arrayList[i] % 2 == 0)
        countChetnihChisel++;

Console.Write("[");
for (int n = 0; n < arrayList.Length; n++)
{
    if(n < arrayList.Length - 1)
        Console.Write($"{arrayList[n]}, ");
    else
        Console.Write($"{arrayList[n]}");
}
Console.WriteLine($"] -> Колличество чётных чисел: {countChetnihChisel}");