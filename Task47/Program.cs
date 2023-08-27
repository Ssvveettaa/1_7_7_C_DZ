// Задача 47:
// Задайте двумерный массив размером m x n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7,0 -2,0 -0,2
// 1,0 -3,3  8,0 -9,9
// 8,0  7,8 -7,1  9,0

double[,] CreateMatrixRandomDouble(int rows, int columns, int min, int max)
{
    double[,] mtrx = new double[rows, columns];
    var random = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = random.NextDouble() * (max - min) + min;
        }
    }
    return mtrx;
}

void OutputMatrixDouble(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j],8:F1}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы (не менее 1 строки): ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 1)
{
    Console.WriteLine();
    Console.WriteLine("Количество строк меньше 1-й.");
    return;
}

Console.Write("Введите количество столбцов матрицы (не менее 1 столбца): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine();
    Console.WriteLine("Количество столбцов меньше 1-го.");
    return;
}

Console.Write("Введите минимальное значение элементов массива (от -999 до 9999): ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива (от -999 до 9999): ");
int maxValue = Convert.ToInt32(Console.ReadLine());
if (minValue < -999 || minValue > 9999 || maxValue < -999 || maxValue > 9999)
{
    Console.WriteLine();
    Console.WriteLine("Значения элементов массива вне интервала: [-999, 9999].");
    return;
}
if (minValue > maxValue)
{
    Console.WriteLine();
    Console.WriteLine("Минимальное значение элементов массива больше максимального.");
    return;
}

// double[,] matrix = new double[3, 4] { { 0.5, 7.0, -2.0, -0.2 }, { 1.0, -3.3, 8.0, -9.9 }, { 8.0, 7.8, -7.1, 9.0 } };
// double[,] matrix = CreateMatrixRandomDouble(3, 4, -10, 10);
double[,] matrix = CreateMatrixRandomDouble(m, n, minValue, maxValue);

Console.WriteLine();
OutputMatrixDouble(matrix);
