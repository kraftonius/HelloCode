// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindMinElemetIndex(int[] arr)
{
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[index]) index = i;
    }
    return index;
}

int FindMinSumRowIndex(int[,] matrix)
{
    int[] sumsArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        sumsArray[i] = sum;
    }
    int result = FindMinElemetIndex(sumsArray);
    return result;
}

Console.WriteLine("Задан двухмерный Массив:");
int[,] array2D = GenerateMatrixRndInt(5, 4, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("");
int minSumRow = FindMinSumRowIndex(array2D);
Console.WriteLine($"Строка с наименьшей суммой элементов {minSumRow + 1}-я строка");
