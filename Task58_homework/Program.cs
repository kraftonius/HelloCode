// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool CanProdMatrix(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int[,] MatrixProduction(int[,] matrixA, int[,] matrixB)
{

    int[,] matrProd = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrProd[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrProd;
}

Console.WriteLine("Задана матрица A:");
int[,] matrixArrA = GenerateMatrixRndInt(4, 2, 0, 10);
PrintMatrix(matrixArrA);

Console.WriteLine("Задана матрица B:");
int[,] matrixArrB = GenerateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(matrixArrB);

if (CanProdMatrix(matrixArrA, matrixArrB))
{
    int[,] matrixProduction = MatrixProduction(matrixArrA, matrixArrB);
    Console.WriteLine("Результат произведения матриц:");
    PrintMatrix(matrixProduction);
}
else
{
    Console.WriteLine($@"Нельзя вычислить произведение двух матриц.
Число столбцов матрицы A не равняется числу строк матрицы B. ");
}