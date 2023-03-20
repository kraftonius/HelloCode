// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 3}, ");
        else Console.Write($"{arr[i], 3}");
    }
    Console.WriteLine("]");
}

int size = Prompt("Длина Массива: ");
int min = Prompt("Минимальное значение случайного числа: ");
int max = Prompt("Максимальное значение случайного числа: ");
int[] array = CreateArrayRndInt(size, min, max);
PrintArray(array);
int[] changedSignsArray = ChangeSign(array);
PrintArray(changedSignsArray);
