// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int min, int max) // Создает массив size - кол-во элементов. min и max - диапазон значений элемента
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

string ArrayStringView(int[] arr) // выводит массив в виде строки (элементы в квадратных скобках и запятыми)
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

int oddIndexElementSum(int[] arr) // возвращает сумму элементов с нечетным индексом
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] arrray = GenerateArray(10, 100, 1000);
int evenQuantity = CountEven(arrray);
Console.WriteLine($"Масcив и количество четных элементов в нем:\n{ArrayStringView(arrray)} - > {evenQuantity}");
