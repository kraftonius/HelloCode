// Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine($"Введите номер четверти: ");
Console.Write($"Четверть: ");
string quarter = Console.ReadLine();

string print = GetRange(quarter);
Console.WriteLine(print);


string GetRange(string quart)
{
    if (quart == "1") return "x > 0 и y > 0";
    if (quart == "2") return "x < 0 и y > 0";
    if (quart == "3") return "x < 0 и y < 0";
    if (quart == "4") return "x > 0 и y < 0";
    return "Введено неверное число!";
}