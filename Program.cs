//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleArray(int row, int column)
{
    double[,] doubleArr = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            doubleArr[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
    return doubleArr;
}
void PrintDoubleArray(double[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintDoubleArray(CreateDoubleArray(3, 4));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateDoubleArray(int row, int column)
{
    int[,] doubleArr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            doubleArr[i, j] = new Random().Next(0, 10);
        }
    }
    return doubleArr;
}
void PrintDoubleArray(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SeachElement(int[,] doubleArr, int firstIndex, int secondIndex)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    if (firstIndex > row || secondIndex > column)
    {
        Console.WriteLine($"Элемента с индексом [{firstIndex},{secondIndex}] в данном массиве нет");
    }
    else
        Console.WriteLine($"Элемент с индексом [{firstIndex}, {secondIndex}] -> {doubleArr[firstIndex, secondIndex]}");
}

int[,] doubleArray = CreateDoubleArray(3, 4);
PrintDoubleArray(doubleArray);
SeachElement(doubleArray, 1, 7);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateDoubleArray(int row, int column)
{
    int[,] doubleArr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            doubleArr[i, j] = new Random().Next(0, 10);
        }
    }
    return doubleArr;
}
void PrintDoubleArray(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] FindColumnArithmeticMean(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    double[] columnArithmeticMeanArray = new double[column];
    double columnSum = 0;
    for (int j = 0; j < column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            columnSum += doubleArr[i, j];
        }
        columnArithmeticMeanArray[j] = Math.Round(columnSum / row, 2);
        columnSum = 0;
    }
    return columnArithmeticMeanArray;
}
void PrintArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,] doubleArray = CreateDoubleArray(3, 4);
PrintDoubleArray(doubleArray);
double[] columnArithmeticMeanArr = FindColumnArithmeticMean(doubleArray);
PrintArray(columnArithmeticMeanArr);