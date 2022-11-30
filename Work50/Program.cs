/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int[,] GetRandomArray(int lengthRow, int lengthCol, int MinValue, int MaxValue)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}

int[] GetNewArray(int[,] array)
{

    int newArraySize = array.GetLength(0) * array.GetLength(1);
    int[] newArray = new int[newArraySize];
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[result] = array[i, j];
            result++;
        }
    }
    return newArray;
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

void GetElement(int[] array)
{
    Console.Write("Введите элемент: ");
    int element = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i <= array.Length; i++)
    {
        if (element == i)
        {
            Console.WriteLine($" Значение элемента под индексом {element} = {array[i]}");
        }
    }

    if (element > array.Length)
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.WriteLine();
    }
    if (element < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.WriteLine();
    }
    }


Console.WriteLine("Двумерный массив:");
int[,] array1 = GetRandomArray(3, 4, 1, 10);
print2dArray(array1);
Console.WriteLine();
Console.WriteLine("Получившийся одномерный массив:");
int[] array2 = GetNewArray(array1);
PrintArray(array2);
Console.WriteLine();
GetElement(array2);





