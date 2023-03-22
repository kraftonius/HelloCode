// Задача 39: Напишите программу, которая 
// 1. перевернёт одномерный массив 
// (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Console.Write($"{arr[j]},");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
    Console.WriteLine();
}

void ReverseArray(int[] arr)
{

    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = GenerateRndArray(5, 1, 9);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);