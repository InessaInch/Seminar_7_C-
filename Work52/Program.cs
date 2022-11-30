/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/ 

int[,] GetRandomArray (int lengthRow, int lengthCol, int MinValue, int MaxValue)
{
    int[,] array = new int[lengthRow,lengthCol];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return array;
}
double[] GetArifOfCol(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j<array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i<array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) Console.Write($" {array[i, j]}  ");
            else System.Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void PrintArray(double[] array)
{

    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int[,] massive = GetRandomArray(4, 4, 1, 10);
Print2DArray(massive);
Console.WriteLine();
double[] ArifOfCol = GetArifOfCol(massive);
PrintArray(ArifOfCol);
Console.WriteLine();
Console.WriteLine();

