// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Console.Write($"{arr[j]},");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
    Console.WriteLine();
}

int[] FindMatrixMinElementIndex(int[,] matrix)
{
    int minRowInd = 0;
    int minColInd = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minRowInd, minColInd] > matrix[i, j])
            {
                minRowInd = i;
                minColInd = j;
            }
        }
    }
    int[] indexesArr = { minRowInd, minColInd };
    return indexesArr;
}

int[,] CutRowColByIndex(int[,] matrix, int rowInd, int colInd)
{
    int[,] cutMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i > rowInd) k = i - 1;
            else k = i;
            if (j > colInd) l = j - 1;
            else l = j;
            if (i == rowInd || j == colInd);
            else cutMatrix[k,l] = matrix[i,j];
        }
    }
    return cutMatrix;
}

Console.WriteLine("Задан двухмерный Массив:");
int[,] array2D = GenerateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

Console.WriteLine("Получим индекс минимального элемента");
int[] minElementIndex = FindMatrixMinElementIndex(array2D);
PrintArray(minElementIndex);

Console.WriteLine($@"Получим массив без строки и столбца,
содержавших минимальный элемент");
int[,] cutRowColByIndex = CutRowColByIndex(array2D, minElementIndex[0], minElementIndex[1]);
PrintMatrix(cutRowColByIndex);