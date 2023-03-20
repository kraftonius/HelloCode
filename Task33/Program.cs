// Задача 33:  Напишите программу, которая
// 1. Задайте массив.
// 2. определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = Convert.ToInt32(ReadInput);
    return result;
}

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

bool HasNumber(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

string ArrayToPrint(int[] arr)
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

int[] array = CreateArrayRndInt(10, 0, 9);
Console.WriteLine(ArrayToPrint(array));
int number = Prompt("Число для поиска: ");
string hasNumber = HasNumber(number, array) ? "да" : "нет";

Console.WriteLine($"{number}; массив {ArrayToPrint(array)} -> {hasNumber}");