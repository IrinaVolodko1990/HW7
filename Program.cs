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
