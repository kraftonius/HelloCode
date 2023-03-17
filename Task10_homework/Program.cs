// Задача 10: 
// Напишите программу, которая
// 1. принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsThreeDigits(number)?GetSecondDigit(number):"Не является трехзначным числом" );


// Функция проверки на трехзначное число. Отрицательные трехзначные тоже считаем трехзначными.
bool IsThreeDigits(int num)
{
    return Math.Abs(num) >= 100 && Math.Abs(num) <= 999;
}


// Функция возвращения второй цифры трехзначного числа
int GetSecondDigit(int numb)
{
    return Math.Abs(numb) / 10 % 10;
}