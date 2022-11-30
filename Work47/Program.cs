﻿/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.*/

double[,] generate2DArray(int lengthRow, int lengthCol, int minNumber, int maxNumber)
{
    double[,] array = new double[lengthRow,lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i,j] = new Random().Next(minNumber, maxNumber + 1);
        }
    }
    return array;
}

void print2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        
        Console.WriteLine("");
    }
}
double[,] array = generate2DArray(3,4,-100,100);
print2dArray(array); 
 

