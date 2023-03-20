// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

string ArrayStringView(int[] arr)
{
    string printArray = String.Empty;
    printArray += "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) printArray += $"{arr[i],2}, ";
        else printArray += $"{arr[i],2}";
    }
    printArray += "]";
    return printArray;
}

int[] GetPairsProdsArray(int[] arr) // Функция вычисления произведения пар
{
    int size = arr.Length; // длина изначального массива
    int length = size % 2 == 0? size / 2 : size / 2 + 1; // длина нового массива с произведениями пар
    int[] PairsSumArray = new int[length];
    for (int i = 0; i < length; i++) // перемножаем пары элементов
    {
        PairsSumArray[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (size % 2 != 0) PairsSumArray[length - 1] = arr[length - 1]; // Если нечетная длина массива, заменяем последний элемент
    return PairsSumArray;
}

int[] array = GenerateArray(7, 1, 9);
int[] pairsProdsArray = GetPairsProdsArray(array);
Console.Write($"{ArrayStringView(array)} -> {ArrayStringView(pairsProdsArray)}");
