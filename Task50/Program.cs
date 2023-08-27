// Задача 50:
// Напишите программу, которая
// на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 –> Такого элемента в массиве нет.

int[,] CreateMatrixIndexesToElements(int rows, int columns)
{
    int[,] mtrx = new int[rows, columns];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] += i;
            int tmp = j;
            while (tmp / 10 > 0)
            {
                mtrx[i, j] *= 10;
                tmp /= 10;
            }
            mtrx[i, j] = mtrx[i, j] * 10 + j;
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
            Console.Write($"{mtrx[i, j], 7}");
        }
        Console.WriteLine();
    }
}

bool CheckElemMatrixByIndexes(int[,] mtrx, int row, int column)
{
    return row >= 0 && row < mtrx.GetLength(0) && column >= 0 && column < mtrx.GetLength(1);
}

Console.Write("Введите индекс строки матрицы: ");
int rowInd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца матрицы: ");
int columnInd = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// int[,] matrix = new int[3, 4] { { 0, 1, 2, 3 }, { 10, 11, 12, 13 }, { 20, 21, 22, 23 } };
int[,] matrix = CreateMatrixIndexesToElements(3, 4);

Console.WriteLine();
OutputMatrix(matrix);
Console.WriteLine();

if (CheckElemMatrixByIndexes(matrix, rowInd, columnInd))
{
    Console.WriteLine($"Элемент в матрице с индексами: {rowInd}, {columnInd} = {matrix[rowInd, columnInd]}.");
}
else Console.WriteLine($"В матрице нет элемента с индексами: {rowInd}, {columnInd}.");
