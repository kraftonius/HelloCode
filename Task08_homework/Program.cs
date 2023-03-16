// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (number == 1) Console.WriteLine("Нет четных чисел от 1 до 1");
else if (number >0)
{
    while (index <= number)
    {
        Console.Write($"{index} ");
        index = index + 2;
    }
}
else
{
    Console.WriteLine("Введено ненатуральное число");
}