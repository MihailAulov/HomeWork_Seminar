// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double InputNumber()
{
    double number;
    Console.Write("Введите число: ");
    number = Convert.ToDouble(Console.ReadLine());
    return number;
}

string numberList = "";
int exitEnterCount = 10;
while(true)
{
    try
    {
        
        Console.WriteLine($"Нажмите на [Enter]x{exitEnterCount}, чтобы увидеть результат и выйти из программы."+
                          $"\nПри вводе ошибки, завершение программы будет через {exitEnterCount} попыток.");
        double inNum = InputNumber();
        numberList +=$"{(Convert.ToString(inNum))} ";
        exitEnterCount = 10;
    }
    catch(System.FormatException)
    {
        exitEnterCount--;
        if(exitEnterCount <= 0)
        {
            numberList = numberList.Remove(numberList.Length-1, 1);
            break;
        }
        Console.WriteLine("Ошибка");
    }
}

int pozitiveNumber = 0;
for (int i = 0; i < numberList.Split(" ").Length; i++)
{
    Console.Write($"{numberList.Split(" ")[i]} ");
    if(Convert.ToDouble(numberList.Split(" ")[i]) > 0)
    {
        pozitiveNumber++;
    }
}
Console.Write($"-> {pozitiveNumber}\n");

