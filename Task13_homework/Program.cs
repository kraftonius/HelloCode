// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Заданное число
int number = -19726;

Console.WriteLine(Math.Abs(number) >= 100 ? GetThird(GetThreeDigits(number)) : "третьей цифры нет");


// Функция получения третьей цифры трехзначного числа
int GetThird(int numz)
{
    return numz % 10;
}


// Функция проверки на трехзначное число. Отрицательные трехзначные тоже считаем трехзначными.
bool IsThreeDigits(int numx)
{
    return Math.Abs(numx) >= 100 && Math.Abs(numx) <= 999;
}


// Функция получения первых трех цифр
int GetThreeDigits(int numy)
{
    while (!IsThreeDigits(numy))
    {
        numy = numy / 10;
    }
    return Math.Abs(numy);
}




