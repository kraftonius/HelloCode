// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

bool StepCheck(int orient, int maxX, int maxY, int x, int y, bool[,] usedCells)
// Проверяет, можно ли сделать шаг с учетом границ массива и ячеек, на которые нельзя наступать
{
    if (orient == 1) return x < maxX && !usedCells[y, x + 1];
    if (orient == 2) return y < maxY && !usedCells[y + 1, x];
    if (orient == 3) return x > 0 && !usedCells[y, x - 1];
    if (orient == 4) return y > 0 && !usedCells[y - 1, x];
    else return false;
}

(int, int, int) StepMake(int orient, int x, int y, int count)
// Делает шаг в зависимости от направления и добавляет счетчик шагов + 1
{
    if (orient == 1) return (y, x + 1, count + 1);
    if (orient == 2) return (y + 1, x, count + 1);
    if (orient == 3) return (y, x - 1, count + 1);
    if (orient == 4) return (y - 1, x, count + 1);
    return (0, 0, 0);
}

int TurnOrientation(int orient)
{
    if (orient >= 1 && orient <= 3) orient += 1;
    else orient = 1;
    return orient;
}

void FillArraySpiral(int[,] matrix, int x, int y) // Заполняет массив спирально начиная с любого элемента
{
    bool[,] usedCells = new bool[matrix.GetLength(0), matrix.GetLength(1)];
    int elementsQuantity = matrix.GetLength(0) * matrix.GetLength(1);
    int orientation = 1; // R=1 D=2 L=3 U=4
    int maxIndexX = matrix.GetLength(1) - 1;
    int maxIndexY = matrix.GetLength(0) - 1;
    int count = 1;

    matrix[y, x] = count;
    usedCells[y, x] = true;

    while (count < elementsQuantity)
    {
        if (StepCheck(orientation, maxIndexX, maxIndexY, x, y, usedCells)) (y, x, count) = StepMake(orientation, x, y, count); 
        else orientation = TurnOrientation(orientation);
        matrix[y, x] = count;
        usedCells[y, x] = true;
    }
}

Console.WriteLine("Создадим пустой двухмерный массив");
int[,] SpiralMatrix = new int[4, 4];
PrintMatrix(SpiralMatrix);

Console.WriteLine("Заполним массив спирально");
int startX = 0;
int startY = 0;
FillArraySpiral(SpiralMatrix, startX, startY);
PrintMatrix(SpiralMatrix);