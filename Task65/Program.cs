// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void NaturalsInRange(uint firstNum, uint secondNum)
{
    if (firstNum < secondNum)
    {
        NaturalsInRange(firstNum, secondNum - 1);
        Console.Write($"{secondNum} ");
    }
    else if (firstNum > secondNum)
    {
        Console.Write($"{firstNum} ");
        NaturalsInRange(firstNum - 1, secondNum);
    }
    else
    {
        Console.Write($"{firstNum} ");
    }
}

Console.Write("Введите первое натуральное число: ");
uint numberM = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
uint numberN = Convert.ToUInt32(Console.ReadLine());
NaturalsInRange(numberM, numberN);
