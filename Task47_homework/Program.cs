// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateMatrixRndDouble(int rows, int columns, int min, int max)
// // Создает вещественных массив целых чисел
// rows - кол-во строк, columns кол-во столбцов, min и max - диапазон значений элементов
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
// Выводит 2-х мерный массив вещественных чисел в консоль в виде таблицы
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

double[,] array2D = GenerateMatrixRndDouble(3, 4, -100, 100);
PrintMatrixDouble(array2D);
