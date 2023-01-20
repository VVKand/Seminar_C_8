// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Вывод двумерного массива 4*4 по спирали:");
int N = 4;
int n = N * N;

int[,] matrix = new int[N, N];

ConvertArray(matrix);
PrintArray(matrix);


void ConvertArray(int[,] matrix)
{
    int m = 0;
    int i = 0;
    int j = 0;

link1:
    for (m = m; m < n; m++)
    {
        if (j < N)
        {
            matrix[i, j] = m + 1;
            j++;
        }
        else
        {
            i++;
            j--;
            for (m = m; m < n; m++)
            {
                if (i < N)
                {
                    matrix[i, j] = m + 1;
                    i++;
                }
                else
                {
                    i--;
                    j--;
                    for (m = m; m < n; m++)
                    {
                        if (j >= 0)
                        {
                            matrix[i, j] = m + 1;
                            j--;
                        }
                        else
                        {
                            i--;
                            j++;
                            for (m = m; m < n; m++)
                            {
                                if (i >= 1)
                                {
                                    matrix[i, j] = m + 1;
                                    i--;
                                }
                                else
                                {
                                    N--;
                                    i++;
                                    j++;
                                    goto link1;
                                }

                            }
                            return;
                        }
                    }
                    return;
                }
            }
            return;
        }

    }
    return;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write("{0: 00}", array[i, j],2 +" ");
        Console.WriteLine();
    }
}
