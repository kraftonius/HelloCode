// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine($"Введите координаты 1-й точки");
Console.Write("X1: ");
int xCoord1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int yCoord1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты 2-й точки");
Console.Write("X2: ");
int xCoord2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yCoord2 = Convert.ToInt32(Console.ReadLine());

double res = GetLength(xCoord1, yCoord1, xCoord2, yCoord2);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine(resRound);


double GetLength(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}