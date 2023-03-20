// Задача 25: 
// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Получаем число A
Console.WriteLine("Введите число, которое возводим в степень:");
int numberA = Convert.ToInt32(Console.ReadLine());

//  Получаем число B; значение uint не может быть отрицательным числом, но может быть 0
Console.WriteLine("Введите натуральное число степени в которую возводим:");
uint numberB = Convert.ToUInt32(Console.ReadLine());
 
// Возвращаем результат функцией GetNPow и выводим ответ
string result = $"{numberA}, {numberB} -> {GetNPow(numberA, numberB)}";
Console.WriteLine(result);


// Функция (Метод) возвращает возведение целого числа A в натуральную степень B (и еще в степень 0)
int GetNPow(int a, uint b)
{
    int pow = 1;
    if (b == 0 && a >= 0) return pow;
    if (b == 0 && a < 0) return -pow;
    for (int i = 1; i <= b; i++)
    {
        pow *= a;
    }
    return pow;
}