// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


////////////
// Вариант на Семинаре
int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.WriteLine("]");
}

int CountTwoDigit(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= 10 && arr[i] <= 99) count++;
}
return count;
}

int[] array = CreateArrayRndInt(123, 0, 150);
PrintArray(array);
int countTwoDigit = CountTwoDigit(array);
Console.WriteLine($"Количество чисел, входящих в отрезок [10, 99] = {countTwoDigit}");







//////////////////////
// Вариант с любым количеством цифр в числе
int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int QuantityOfDigits(int numb)
{
{
    if (numb == 0) return 1;
    return Convert.ToInt32(Math.Round(Math.Log10(Math.Abs(numb)), 0, MidpointRounding.ToZero)) + 1;
}
}


int GetQuantityNumbersGivenDigitsQuantity(int[] arr, int givenDigitsQuantity) // Посчитать количество чисел в массиве с заданным количеством цифр
{
    int qty = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (QuantityOfDigits(arr[i]) == givenDigitsQuantity) qty ++;  
    }
    return qty;
}

string ArrayStringView(int[] arr)
{
    string printArray = String.Empty;
    printArray += "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) printArray += $"{arr[i], 2}, ";
        else printArray += $"{arr[i], 2}";
    }
    printArray += "]";
    return printArray;
}

int targetQuantityOfDigits = 2; // Задаем количество цифр в тех числах, которые нужно суммировать
int[] arraydata = GenerateArray(123, 0, 150); // Задаем массив
int quantity = GetQuantityNumbersGivenDigitsQuantity(arraydata, targetQuantityOfDigits);
Console.WriteLine($"{ArrayStringView(arraydata)} -> {quantity}");