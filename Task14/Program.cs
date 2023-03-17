// 14. Напишите программу, которая
// 1. принимает на вход число
// 2. и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int multi1 = 7;
int multi2 = 23;

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string print = isMulti(number, multi1, multi2) ? "Да" : "Нет";
Console.WriteLine(print);


bool isMulti (int num, int mul1, int mul2)
{
    return num % mul1 == 0 && num % mul2 == 0; 
}