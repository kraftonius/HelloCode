// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2;
// for x
// k2x + b2 = k1x + b1; 
// k2x - k1x = b1 - b2;
// x = (b1 - b2) / (k2 - k1);
// for y
// y = k1x + b1;
// y = k1((b1 - b2) / (k2 - k1)) + b1;
// y = ( k1((b1 - b2) + b1(k2 - k1) ) / (k2 - k1);
// y = ( k1b1 - k1b2 + k2b1 - k1b1) / (k2 - k1);
// y = (k1b2 - k2b1) / (k1 - k2);

double PromptDouble(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    double result = Convert.ToDouble(ReadInput);
    return result;
}

bool IsParallel(double k1, double k2)
{
    return k1 == k2;
}

bool IsSameLine(double b1, double k1, double b2, double k2)
{
    return k1 == k2 && b1 == b2;
}


double GetXCoord(double b1, double k1, double b2, double k2)
{
    return (b1 - b2) / (k2 - k1);
}

double GetYCoord(double b1, double k1, double b2, double k2)
{
    return ((k1 * b2 - k2 * b1) / (k1 - k2));
}

Console.WriteLine("Для уравнений: y = k1 * x + b1, y = k2 * x + b2 введите значения");
double b1Value = PromptDouble("Введите значение b1: ");
double k1Value = PromptDouble("Введите значение k1: ");
double b2Value = PromptDouble("Введите значение b2: ");
double k2Value = PromptDouble("Введите значение k2: ");

if (IsSameLine(b1: b1Value, k1: k1Value, b2: b2Value, k2: k2Value))
{
    Console.WriteLine("Линии совпадают");
}
else if (IsParallel(k1: k1Value, k2: k2Value))
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double xCoord = GetXCoord(b1: b1Value, k1: k1Value, b2: b2Value, k2: k2Value);
    double yCoord = GetYCoord(b1: b1Value, k1: k1Value, b2: b2Value, k2: k2Value);
    Console.WriteLine($"b1 = {b1Value}, k1 = {k1Value}, b2 = {b2Value}, k2 = {k2Value} -> ({xCoord}; {yCoord})");
}



