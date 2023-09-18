﻿// Задача 29: Пользователь вводит 8 чисел.
// Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNumberLenghtMassiv()
{
    while(true)
    {
        try
        {
            Console.Write("Введите длину массива: ");
            int NumberLenghtMassiv = Convert.ToInt16(Console.ReadLine());
            return NumberLenghtMassiv;
            break;
        }
        catch(System.FormatException)
        {
            Console.WriteLine("Ошибка!");
        }
        catch(System.OverflowException)
        {
            Console.WriteLine("Ошибка!");
        }
    }
}

double[] InputArrayListNumber(int lenghtMassiv)
{
    double[] numList = new double[lenghtMassiv];
    for (int i = 0; i < lenghtMassiv; i++)
    {
        while(true)
        {
            try
            {
                Console.Write($"Nomer {i+1}. Введите число: ");
                numList[i] = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch(System.FormatException)
            {
                Console.WriteLine($"Nomer {i+1}. Ошибка!");
            }
        }
    }
    return numList;
}

double[] resultNumberList = InputArrayListNumber(8);
Console.WriteLine(string.Join(", ", resultNumberList));