// Задача 27: 
// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// Получаем число от пользователя
Console.WriteLine($"Введите число:");
Console.Write($"Число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Получаем и выводим ответ
Console.WriteLine(GetDigitsSum(number));


// Функция (Метод) суммирования цифр числа
int GetDigitsSum(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
