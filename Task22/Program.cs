// Задача22:
// Напишите программу, которая
// 1. принимает на вход число (N)
// 2. и выдает таблицу квадратов числел от 1 до N
// 5 -> 1, 3, 9, 16, 25.
// 2 -> 1, 4

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SquaresTable(int num)
{
    if (num > 0)
    {
        int index = 1;
        while (index <= num)
        {
            Console.WriteLine($"{index, 5} -> {index * index, 5}");
            index++;
        }
    }
    else
    {
        Console.WriteLine("Введено ненатуральное число");
    }
}

SquaresTable(number);


