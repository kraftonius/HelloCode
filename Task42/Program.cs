// Задача 42: Напишите программу, которая 
// 1. будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ConvetIntToBin(int num) 
{
    int bin = 0;
    int multiplier = 1;

    while (num != 0)
    {
        bin += (num % 2) * multiplier;
        num /= 2;
        multiplier *= 10;
    }
    return bin;
}

int number = 45;
Console.WriteLine($"{number} -> {ConvetIntToBin(number)}");
