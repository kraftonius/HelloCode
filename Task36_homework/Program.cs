// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateRndArray(int size, int min, int max)
// Создает массив целых чисел
// size - кол-во элементов. min и max - диапазон значений элементов
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int OddIndexElementSum(int[] arr)
// возвращает сумму элементов с нечетным индексом
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] array = GenerateRndArray(7, 0, 100);
int oddIndexSum = OddIndexElementSum(array);
Console.WriteLine($@"Масcив и сумма элементов с нечетным индексом:
{IntArrayStringView(array)} - > {oddIndexSum}");
