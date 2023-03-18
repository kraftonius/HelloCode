// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ввести 3 координаты точки A
Console.WriteLine($"Введите координаты 1-й точки");
Console.Write("X1: ");
int xCoord1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int yCoord1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int zCoord1 = Convert.ToInt32(Console.ReadLine());

// ввести 3 координаты точки B
Console.WriteLine($"Введите координаты 2-й точки");
Console.Write("X2: ");
int xCoord2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yCoord2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int zCoord2 = Convert.ToInt32(Console.ReadLine());

// рассчитать и вывести
double result = GetLength(xCoord1, yCoord1, zCoord1, xCoord2, yCoord2, zCoord2);
double roundResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({xCoord1},{yCoord1},{zCoord1}); B ({xCoord2},{yCoord2},{zCoord2}) -> {roundResult}");

// Функция вычесления длины отрезка по координатам точек в трехмерном пространстве
double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}
