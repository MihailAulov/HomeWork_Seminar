﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// 
// Например, на выходе получается вот такой массив:
// 
//  01  02  03  04
// 
//  12  13  14  05
// 
//  11  16  15  06
// 
//  10  09  08  07



void WriteArray2D<T>(T[,] inputArrayND, int lenghtValue)
{
    int rowsCount = inputArrayND.GetUpperBound(0) + 1;    
    int collumsCount = inputArrayND.Length / rowsCount;   

    for (int x = 0; x < rowsCount; x++)
    {
        for (int y = 0; y < collumsCount; y++)
        {
            string value = Convert.ToString(inputArrayND[x, y]);
            for (int i = value.Length; i < lenghtValue; i++)
            {
                value = "0" + value;
            }

            Console.Write(value + "  ");
        }
        Console.WriteLine("\n");
    }
}



double MovePoint2d(ref double[,] inputArray, ref int pointRow, ref int pointCollum, ref int upledori, int count)
{
   
    int cylcle = 0;
    while (cylcle <= 1)
    {
        
        if (upledori == 0) 
        {
            bool up = false;
            try { up = (inputArray[pointRow - 1, pointCollum] == 0); }
            catch { up = false; }
            if (up) 
            {
                inputArray[pointRow, pointCollum] = count;
                pointRow--;
                return count;
            }
            upledori = 1;
        }

        if (upledori == 1) 
        {
            bool left = false;
            try { left = (inputArray[pointRow, pointCollum - 1] == 0); }
            catch { left = false; }
            if (left) 
            {
                inputArray[pointRow, pointCollum] = count;
                pointCollum--;
                return count;
            }
            upledori = 2;
        }

        if (upledori == 2) 
        {

            bool down = false;
            try { down = (inputArray[pointRow + 1, pointCollum] == 0); }
            catch { down = false; }
            if (down) 
            {
                inputArray[pointRow, pointCollum] = count;
                pointRow++;
                return count;
            }
            upledori = 3;
        }

        if (upledori == 3)
        {

            bool right = false;
            try { right = (inputArray[pointRow, pointCollum + 1] == 0); }
            catch { right = false; }
            if (right) 
            {
                inputArray[pointRow, pointCollum] = count;
                pointCollum++;
                return count;
            }
            upledori = 0;
        }

        cylcle++;
    }

    return count;
}




double[,] arraySpiral = ArrayMy.Create2DArray(4, 4);

int pointX = 0, pointY = 0;
int[] pozitionPointXY = new int[] { pointX, pointY };

int upledori = 3;
for (int i = 1; i <= arraySpiral.GetLength(0) * arraySpiral.GetLength(1); i++)
{
    pozitionPointXY[0] = pointX;
    pozitionPointXY[1] = pointY;

    arraySpiral[pozitionPointXY[0], pozitionPointXY[1]] = MovePoint2d(ref arraySpiral, ref pointX, ref pointY, ref upledori, i);
}

WriteArray2D(arraySpiral, Convert.ToString(arraySpiral.GetLength(0) * arraySpiral.GetLength(1)).Length);