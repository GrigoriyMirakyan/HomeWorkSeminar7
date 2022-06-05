/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number = 0;
    while (isInputInt)
    {
        Console.Write(text);
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
            else
            {
                number = numberInt;
                isInputInt = false;
            }
        }
        else
            Console.WriteLine("Ввели не число");
    }
    return number;
}

int[,] InitMatrix(int firstDemension, int secondDemension)   // Создание и наполнение матрицы
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(1, 20);
    }

    return matrix;
}

int LookToMatrix(int m, int n, int[,] matrix)
{
    int desired = 0;
    if (m - 1 < matrix.GetLength(0) && n - 1 < matrix.GetLength(1))
    {
        desired = matrix[m - 1, n - 1];
        Console.WriteLine($"искомый элемент -> {desired}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    return desired;
}

void PrintMatrix(int[,] matrix)    // Вывод матрицы в консоль
{
    Console.WriteLine("Заполненная матрица");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");

        Console.WriteLine();
    }
}

int firstDemension = NumberInput("Введите кол-во строк:  ");
int secondDemension = NumberInput("Введите столбцов:  ");

int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix);

int m = NumberInput("введите номер строки:  ");
int n = NumberInput("Введите номер столбца:  ");

LookToMatrix(m, n, resultMatrix);