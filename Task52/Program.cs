// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] mtrx = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = random.Next(min, max + 1);
        }
    }
    return mtrx;
}

void OutputMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j], 5}");
        }
        Console.WriteLine();
    }
}

double[] AverageElementsColumnsMatrix(int[,] mtrx)
{
    double[] arr = new double[mtrx.GetLength(1)];
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            arr[j] += mtrx[i, j];
        }
        arr[j] /= mtrx.GetLength(0);
    }
    return arr;
}

void OutputArrayDouble(double[] arr, int round = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], round, MidpointRounding.ToZero);
        if (i < arr.Length - 1) Console.Write($"{roundNum}; ");
        else Console.Write($"{roundNum}.");
    }
}

// int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; // –> 4,6; 5,6; 3,6; 3.
int[,] matrix = CreateMatrixRandomInt(3, 4, 1, 9);
double[] averages = AverageElementsColumnsMatrix(matrix);

Console.WriteLine();
OutputMatrix(matrix);
Console.WriteLine();

Console.Write($"Среднее арифметическое элементов в каждом столбце: ");
OutputArrayDouble(averages);
Console.WriteLine();
