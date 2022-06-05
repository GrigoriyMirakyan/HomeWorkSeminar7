﻿/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] InitMatrix(int firstDemension, int secondDemension)   // Создание и наполнение матрицы
{
    double[,] matrix = new double[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.NextDouble() * 10;
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)    // Вывод матрицы в консоль
{
    Console.WriteLine("Заполненная матрица");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,6:F1}", matrix[i, j]);

        Console.WriteLine();
    }
}

int firstDemension = 3;
int secondDemension = 4;

double[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix);
