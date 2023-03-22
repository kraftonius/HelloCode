// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

int PromptInt(string message)
// Предлагает пользователю ввод и возвращает введенное число Int
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = Convert.ToInt32(ReadInput);
    return result;
}

bool HasIndexInMatrix(int[,] matrix, int row, int column)
// Проверяет на наличие индекс в массиве
{
    return row <= matrix.GetLength(0) && column <= matrix.GetLength(1)
    && row > 0 && column > 0;
}

int GetElementBy2DIndex(int[,] matrix, int row, int column)
// Возвращает Элемент по Индексам ряда и столбца
{
    return matrix[row - 1, column - 1];
}

Console.WriteLine("Дана таблица: ");
int[,] array2D = GenerateMatrixRndInt(4, 5, -25, 25);
PrintMatrix(array2D);

int rowIndex = PromptInt("Введите позицию искомого элемента таблицы (начиная с 1) по вертикали: ");
int columnIndex = PromptInt("Введите позицию искомого элемента таблицы (начиная с 1) по горизонтали: ");
if (HasIndexInMatrix(array2D, rowIndex, columnIndex))
{
    Console.WriteLine($"Искомый элемент: {GetElementBy2DIndex(array2D, rowIndex, columnIndex)}");
}
else Console.WriteLine("Элемента с такой позицией не существует в данной таблице.");
