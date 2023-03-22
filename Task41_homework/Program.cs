// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] PromptArray(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int num = Convert.ToInt32(ReadInput);
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i+1} из {num}: ");
        string ReadInput2 = Console.ReadLine();
        arr[i] = Convert.ToInt32(ReadInput2);
    }
    return arr;
}

int CountPositive(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) quantity++;
    }
    return quantity;
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

int[] array = PromptArray("Введите количество чисел для ввода: ");
int countPositive = CountPositive(array);
Console.WriteLine($"{IntArrayStringView(array)} -> {countPositive}");