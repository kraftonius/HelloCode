// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int newNumber = removeSecondDigit(number);
Console.WriteLine($"{number} -> {newNumber}");


int removeSecondDigit(int num)
{ 
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int newNum = firstDigit * 10 + thirdDigit;  
    return newNum;
}