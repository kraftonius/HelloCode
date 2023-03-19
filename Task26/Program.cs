// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/////////////////////////
// мое решение
Console.WriteLine($"Введите целое число:");
Console.Write($"Число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = qDigits(number);
Console.WriteLine($"{number} -> {result}");


int qDigits(int num)
{
    if (num == 0) return 1;
    return Convert.ToInt32(Math.Round(Math.Log10(Math.Abs(num)), 0, MidpointRounding.ToZero)) + 1;
}

// //////////////
// // Другие решения
// // While
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int digits = Digits(number);
// Console.WriteLine($"В числе {number} {digits} цифр");

// int Digits (int num)
// {
// if (num < 0) num = -num;
// if (num == 0) return 1;
// int count = 0;
// while( num > 0)
// {
// num = num / 10;
// count++;
// }
// return count;
// }

// //////////////////////
// // do While
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int digits = Digits(number);
// Console.WriteLine($"В числе {number} {digits} цифр");

// int Digits (int num)
// {
// int count = 0;

// do 
// {
// num /= 10;
// count++;
// } while( num != 0);
// return count;
// }