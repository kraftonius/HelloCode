// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа
// 2. и выводить, является ли первое число
// кратным второму. 
// 3. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int mod = getMod(number1, number2);

string result = mod == 0 ? "кратно" : $"не кратно, остаток {mod}";
Console.WriteLine(result);

int getMod(int num1, int num2)
{
    return num1 % num2;
}