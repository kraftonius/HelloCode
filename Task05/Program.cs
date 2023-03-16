/*
Напишите программу, которая
1. На вход принимает одно число N,
2. На выходе показывает все числа в промежутке от -N до N
4 -> "-4,-3,-2,-1,0,1,2,3,4"
2 -> "-2,-1,0,1,2"
*/
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0)
{
    int index = -number;
    while (index <= number)
    {
        Console.Write($"{index}, ");
        index++;
    }
}
else
{
    Console.WriteLine("Введено ненатуральное число");
}