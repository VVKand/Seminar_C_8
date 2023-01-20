﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] newarray = new int[rows, cols];
int[] sum = new int[rows];

FillArray(newarray);
PrintArray(newarray);
SummRows(newarray);
Console.WriteLine();
MinSum(sum);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} ");
        Console.WriteLine();
    }
}

void SummRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
              sum[i] = sum[i] + array[i, j];
    }
    return;
}

void MinSum(int[] minsum)
{
    int minrow = minsum[0];
    int indexmin = 0;
    for (int i = 1; i < minsum.Length; i++)
    {
            if (minrow > minsum[i])
        {
            minrow = minsum[i];
            indexmin = i;
        }
        
    }
    
    Console.WriteLine($"Минимальная сумма чисел в строке {indexmin}");
}

