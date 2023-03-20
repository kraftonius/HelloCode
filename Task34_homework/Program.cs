// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int CountEven(int[] arr) // подсчитывает количество четных чисел
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

string ArrayStringView(int[] arr) // выводит массив в виде строки в квадратных скобках и запятыми между элементами
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


int[] arrray = GenerateArray(10, 100, 1000);
int evenQuantity = CountEven(arrray);
Console.WriteLine($"Масcив и количество четных элементов в нем:\n{ArrayStringView(arrray)} - > {evenQuantity}");

