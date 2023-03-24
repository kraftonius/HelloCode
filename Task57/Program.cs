// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] GenerateRndIntArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] tempArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempArray[k] = matrix[i, j];
            k++;
        }
    }
    return tempArray;
}

int[,] FreqDict(int[] arr) // Возвращает 2-х мерный массив (частотный словарь)
{
    Array.Sort(arr); // Отсортируем массив
    int[,] countMatrix = new int[2, arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        countMatrix[0, i] = arr[i];
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == arr[i]) countMatrix[1, i]++;
        }
    }
    int[] uniqueNumbers = arr.Distinct().ToArray();
    int count = 1;
    int temp = countMatrix[0,0];
    int[,] uniqueCountMatrix = new int[uniqueNumbers.Length, 2];
    uniqueCountMatrix[0,0] = countMatrix[0, 0];
    uniqueCountMatrix[0,1] = countMatrix[1, 0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (countMatrix[0,i] == temp);
        else 
        {
            uniqueCountMatrix[count, 0] = countMatrix[0, i];
            uniqueCountMatrix[count, 1] = countMatrix[1, i];
            temp = countMatrix[0, i];
            count++;
        }
    }
    return uniqueCountMatrix;
}

void PrintFreqDict(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {            
        Console.Write($"число {matrix[i, 0],3} встречается {matrix[i, 1],3} раз(а)");
        Console.WriteLine();
    }
}


Console.WriteLine("Задан двухмерный Массив:");
int[,] array2D = GenerateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("Получим одномерный массив:");
int[] linedArray = MatrixToArray(array2D);
PrintArray(linedArray);

Console.WriteLine($@"Получим Частотный словарь
с количеством вхождений чисел в изначальный массив:");
int[,] freqDict = FreqDict(linedArray);
PrintFreqDict(freqDict);
