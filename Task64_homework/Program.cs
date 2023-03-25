// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

uint PromptUint(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    uint result = Convert.ToUInt32(ReadInput);
    return result;
}

void NaturalNumbers(uint num)
{
    if(num == 0) return;
    if (num == 1) Console.Write($"{num}");
    else Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}

uint number = PromptUint("Введите натуральное число: ");
Console.Write($"N = {number} -> \"");
NaturalNumbers(number);
Console.Write($"\"");
