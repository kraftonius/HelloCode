// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

SquaresTable(number);


// Войд функция с выводом таблицы в терминал
void SquaresTable(int num)
{
    if (num > 0)
    {
        int index = 1;
        while (index <= num)
        {
            Console.WriteLine($"{index, 5} -> {Math.Pow(index, 3), 5}");
            index++;
        }
    }
    else
    {
        Console.WriteLine("Введено ненатуральное число");
    }
}

