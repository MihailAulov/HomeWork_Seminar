﻿// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой).
// Они могут быть положительными или отрицательными.
// Примеры: 15, 56.22, 0.0, -232336.11


// int count = 25;
int arrayLenght = 10;
int rndDoubleLenght = 101;
// double rndDoubleLenghtMin = -rndDoubleLenghtMax;

double[] arrayDoubleList = new double[arrayLenght];

for (int i = 0; i < arrayLenght; i++)
{
    arrayDoubleList[i] = new Random().Next(0, rndDoubleLenght);
}



for (int i = 0; i < arrayDoubleList.Length; i++)
{
    Console.Write($"{arrayDoubleList[i]} ");
}
Console.WriteLine();


double[] minIndex = new double[] {arrayDoubleList[0], 0};
double[] maxIndex = new double[] {arrayDoubleList[0], 0};
for (int i = 1; i < arrayDoubleList.Length; i++)
{
    if(minIndex[0] > arrayDoubleList[i])
    {
        minIndex[0] = arrayDoubleList[i];
        minIndex[1] = i;
    }
    else if(maxIndex[0] < arrayDoubleList[i])
    {
        maxIndex[0] = arrayDoubleList[i];
        maxIndex[1] = i;
    }
}

Console.WriteLine($"minValue: {minIndex[0]}, maxValue: {maxIndex[0]}\n" 
                 +$"minIndex: {minIndex[1]}, maxIndex: {maxIndex[1]}");

double theDifferenceBetweenTheMaximumAndMinimumInTheValue = Math.Abs(maxIndex[0] - minIndex[0]);
int theDifferenceBetweenTheMaximumAndMinimumInTheIndex = Math.Abs(Convert.ToInt32(maxIndex[1]) - Convert.ToInt32(minIndex[1]));

Console.WriteLine($"Разница между Min и Max в значение: {theDifferenceBetweenTheMaximumAndMinimumInTheValue}\n"
                 +$"Растояние между Min и Max в индексе: {theDifferenceBetweenTheMaximumAndMinimumInTheIndex}");