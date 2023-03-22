// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateMatrixRndInt(int rows, int columns, int min, int max)
// // Создает двухмерный массив целых чисел
// rows - кол-во строк, columns кол-во столбцов, min и max - диапазон значений элементов
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
// Выводит 2-х мерный массив целых чисел в консоль в виде таблицы
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

double[] GetColumnsAverages(int[,] matrix)
// возвращает массив средних арифметических значений 
// каждого столбца двухмерного массива
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arr[j] += matrix[i, j];
        }
        arr[j] /= matrix.GetLength(0);
    }
    return arr;
}

void PrintArrayDoubleElements(double[] arr)
// Выводит массив вещественных чисел в консоль 
// в виде элементов через точку с запятой
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Console.Write($"{Math.Round(arr[j], 1)}; ");
    }
    Console.Write($"{Math.Round(arr[arr.Length - 1], 1)}.");
    Console.WriteLine();
}

Console.WriteLine("Задан двухмерный массив:");
int[,] array2D = GenerateMatrixRndInt(6, 8, 0, 9);
PrintMatrix(array2D);

Console.WriteLine("Среднее арифметическое каждого столбца:");
double[] array = GetColumnsAverages(array2D);
PrintArrayDoubleElements(array);

