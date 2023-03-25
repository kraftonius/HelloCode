// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateMatrixRndInt(int rows, int columns, int min, int max)
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

void SortMatrixRows(int[,] matrix)
{
    bool sorted = true;
    int temp = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                sorted = true;
                while (sorted)
                    if (matrix[k, j] < matrix[k, j + 1])
                    {
                        temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                        sorted = true;
                    }
                    else sorted = false;
            }
        }
    }
}

Console.WriteLine("Задан двухмерный Массив:");
int[,] array2D = GenerateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("Упорядочим по убыванию элементы каждой строки:");
SortMatrixRows(array2D);
PrintMatrix(array2D);