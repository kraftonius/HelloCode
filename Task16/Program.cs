// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string print = isSquare(number1, number2) ? "Да" : "Нет";
Console.WriteLine(print);


bool isSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

