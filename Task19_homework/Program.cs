// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine($"Введите пятизначное число: ");
// Console.Write($"Число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// // Тернарная операция вложена в тернарную операцию, что дает 3 варианта ответа
// // да / нет / не пятизначное число
// string result = isFiveDigit(number) ? isPalindrom(number) ? $"{number} -> да" : $"{number} -> нет" : "не пятизначное число";
// Console.WriteLine(result);


// // Функция проверки числа на пятизначность
// bool isFiveDigit(int numb)
// {
//     return numb >= 10000 && numb <= 99999;
// }


// // Функция "разворота" числа
// int InvertNumber(int num)
// {
//     string numString = Convert.ToString(num);
//     int length = numString.Length;
//     int invertNum = 0;

//     for (int i = 1; i < length; i++)
//     {
//         int mod = num % 10;
//         invertNum = invertNum + mod * Convert.ToInt32(Math.Pow(10, length - i));
//         num = num / 10;
//     }
//     invertNum = invertNum + num;
//     return invertNum;

//     // Console.WriteLine(invertNum);
// }


// // Функция определения Палиндрома
// bool isPalindrom(int num1)
// {
//     return num1 == InvertNumber(num1);
// }


/////////////////////////////////////////////////////////
// Исправлено после комментария преподавателя:
// 1. Теперь работает с отрицательными числами
// 2. Теперь не использует String.Length для определения длины числа. Испольует log10 + 1
//
// Исправлено так же:
// 3. Выводит результат из функции
// 4. Добавлены параметры определения отрезка для количества знаков(цифр) для числа


/////////////////////////////////////////////////////////
// Определяем со скольки-значными числами работает алгоритм: от ... до ... знаков
int digitLimitMin = 5;
int digitLimitMax = 5;

// Приветствуем
Console.WriteLine("Доброго времени суток! Это программа определяет, является лит число палиндромом.");

// Получаем число от пользователя
Console.WriteLine($"Введите целое число (можно отрицательное), где количество цифр не более {digitLimitMin} и не менее {digitLimitMax}: ");
Console.Write($"Число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Используем функцию определения Палиндрома "isPalindrom" и выводим результат
string result = isPalindrom(number, digitLimitMin, digitLimitMax);
Console.WriteLine(result);


/////////////////////////////////////////////////////////
// Функция Получения количества цифр в числе
int qDigits(int numb)
{
    return Convert.ToInt32(Math.Round(Math.Log10(Math.Abs(numb)), 0, MidpointRounding.ToZero)) + 1;
}


// Функция "разворота" числа
int InvertNumber(int num)
{
    // Инициализируем переменную записи инвертированнового числа
    int invertNum = 0;
    
    // Определяем длину числа способом: log10(x) + 1 вместо String.Length
    int length = qDigits(num);
    
    // Собираем инвертированное число циклом до предпоследнего числа
    for (int i = 1; i < length; i++)
    {
        int mod = num % 10;
        invertNum = invertNum + mod * Convert.ToInt32(Math.Pow(10, length - i));
        num = num / 10;
    }
    // Собираем последнее число
    invertNum = invertNum + num;
    return invertNum;
}


// Функция определения Палиндрома
string isPalindrom(int num1, int minDigits, int maxDigits)
{
    // приводим число к положительному для определения палиндрома
    if (qDigits(num1) >= minDigits && qDigits(num1) <= maxDigits)
    {
        if (num1 == InvertNumber(num1))
        {
            return $"{num1} -> да";
        }
        else
        {
            return $"{num1} -> нет";
        }
    }
    else
    {
        return ($"количество цифр в числе {num1} за пределами ограничений: min = {digitLimitMin}; max = {maxDigits}");
    }
}
