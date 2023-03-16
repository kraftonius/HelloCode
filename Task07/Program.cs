/*
7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трезначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = 0;

if (number < 0)
{
number = - number;
}

if (number <= 999 && number >= 100)
{
    lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа {number}: {lastDigit} ");
}
else
{
    Console.WriteLine("Вы ввели не трезначное число: ");
}