// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число");
uint number = Convert.ToUInt32(Console.ReadLine());

string result = GetNFactorial(number);
Console.WriteLine(result);


string GetNFactorial(uint num)
{
    double prod = 1;
    if (num == 0) return "0 не является натуральным числом";
    for (uint i = 1; i <= number; i++)
    checked
    {
        prod *= i;    
    }
    return $"{num} -> {prod}";
}

