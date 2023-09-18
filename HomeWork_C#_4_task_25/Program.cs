﻿// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Raise_a_number_to_a_power(double num, double pow)
{
    
    try
    {
        double[] num_pow = new double[] {num, pow};
        double numberPOW = num_pow[0];
        // if(pow >= 1)
        {
            for (double i = 1; i < (num_pow[1]); i++)
            {
                numberPOW *= num_pow[0];
            }
        }
        // else if(pow < 1)
        // {
        //     for (double i = 1; i < (num_pow[1]); i++)
        //     {
        //         numberPOW *= num_pow[0];
        //     }
        // }
        return numberPOW;
    }
    catch(System.FormatException)
    {
        Console.WriteLine($"Ошибка! Неверный формат. {num}, {pow}");
        return 0;
    }
    
}


Console.Write("Введите первое число, затем нажмите на [Enter], и введите второе число.\nВведите число: ");
double[] inputNumberAndPow = new double[] {double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())};

double result = Raise_a_number_to_a_power(num:inputNumberAndPow[0], pow:inputNumberAndPow[1]);
Console.WriteLine($"{inputNumberAndPow[0]}, {inputNumberAndPow[1]} -> {result} ({inputNumberAndPow[0]}^{inputNumberAndPow[1]})");


// double x = inputNumberAndPow[0];
// double sqrt = inputNumberAndPow[1];
// double result1 = Math.Exp(sqrt*Math.Log(x));
// Console.WriteLine(result1);