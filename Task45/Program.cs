// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


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

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
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

int[] array = GenerateRndArray(5, 1, 9);
int[] copyArray = CopyArray(array);
Console.WriteLine($"{IntArrayStringView(array)} -> {IntArrayStringView(copyArray)}");
