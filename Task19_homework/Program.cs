// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine($"Введите пятизначное число: ");
Console.Write($"Число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Тернарная операция вложена в тернарную операцию, что дает 3 варианта ответа
// да / нет / не пятизначное число
string result = isFiveDigit(number) ? isPalindrom(number) ? $"{number} -> да" : $"{number} -> нет" : "не пятизначное число";
Console.WriteLine(result);


// Функция проверки числа на пятизначность
bool isFiveDigit(int numb)
{
    return numb >= 10000 && numb <= 99999;
}


// Функция "разворота" числа
int InvertNumber(int num)
{
    string numString = Convert.ToString(num);
    int length = numString.Length;
    int invertNum = 0;

    for (int i = 1; i < length; i++)
    {
        int mod = num % 10;
        invertNum = invertNum + mod * Convert.ToInt32(Math.Pow(10, length - i));
        num = num / 10;
    }
    invertNum = invertNum + num;
    return invertNum;

    // Console.WriteLine(invertNum);
}


// Функция определения Палиндрома
bool isPalindrom(int num1)
{
    return num1 == InvertNumber(num1);
}