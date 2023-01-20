// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] newarray = new int[rows, cols];

FillArray(newarray);
PrintArray(newarray);
BubbleSort(newarray);
Console.WriteLine("Массив после сортировки строк:");
PrintArray(newarray);

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

void BubbleSort(int[,] sort)
{
    for (int i = 0; i < sort.GetLength(0); i++)
    {
        for (int j = 0; j < sort.GetLength(1); j++)
        {
            for (int e = j + 1; e < sort.GetLength(1); e++)
            {
                if (sort[i, e] > sort[i, j])
                {
                    int temp = sort[i, j];
                    sort[i, j] = sort[i, e];
                    sort[i, e] = temp;
                }
            }
        }
    }
}

