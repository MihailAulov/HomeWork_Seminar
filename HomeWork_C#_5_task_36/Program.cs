﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayGeneratorNumber(int count, int min, int max)
{
    int[] arrayList = new int[count];
    for (int i = 0; i < count; i++)
       arrayList[i] = new Random().Next(min, max);
    return arrayList;
}

int[] arrayList = ArrayGeneratorNumber(10, -100, 101);

int countSumChetnihChisel = 0;
for (int i = 1; i < arrayList.Length; i += 2)
    countSumChetnihChisel += arrayList[i];
        

Console.Write("[");
for (int n = 0; n < arrayList.Length; n++)
{
    if(n < arrayList.Length - 1)
        Console.Write($"{arrayList[n]}, ");
    else
        Console.Write($"{arrayList[n]}");
}
Console.WriteLine($"] -> Сумма чисел на нечётных позициях: {countSumChetnihChisel}");