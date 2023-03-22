// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int PromptInt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = Convert.ToInt32(ReadInput);
    return result;
}

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

int sideA = PromptInt("Введите длину 1-й стороны: ");
int sideB = PromptInt("Введите длину 2-й стороны: ");
int sideC = PromptInt("Введите длину 3-й стороны: ");
string isExistTriangl = IsExistTriangle(sideA, sideB, sideC) ? "Существует" : "Не существует";
Console.WriteLine($@"Сторона A = {sideA}, Сторона B = {sideB}, Сторона C = {sideC}
Треугольник со сторонами такой длины:
{isExistTriangl}!");

