// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void SwapRowsColumns(int[,] matrix)
{
    int temp = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;

        }
    }
}

Console.WriteLine("Задан Массив:");
int[,] array2D = GenerateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);

if (IsSquareMatrix(array2D))
{
    Console.WriteLine("Поменяем строки и столбцы местами:");
    SwapRowsColumns(array2D);
    PrintMatrix(array2D);
}
else
    Console.WriteLine("Матрица не симметричная:");