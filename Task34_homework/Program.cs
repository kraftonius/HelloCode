// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateRndArray(int size, int min, int max) // Создает массив size - кол-во элементов. min и max - диапазон значений элементов
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int CountEvenElements(int[] arr) // подсчитывает количество четных чисел
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

string IntArrayStringView(int[] arr)
// Возвращает массив целых чисел внутри квадратных скобок через запятую
// [34, 26, 76, 88, 45,  8, 62]
{
    string printArray = "[";

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) printArray += $"{arr[i],2}, ";
        else printArray += $"{arr[i],2}]";
    }
    return printArray;
}


int[] arrray = GenerateRndArray(10, 100, 1000);
int evenQuantity = CountEvenElements(arrray);
Console.WriteLine($@"Масcив и количество четных элементов в нем:
{IntArrayStringView(arrray)} - > {evenQuantity}");

