// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FibonacciArray(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i-2] + arr[i-1];
    }
    return arr;
}

void PrintArraySplitSpace(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");       
    }
    Console.WriteLine(); 
}

int number = 20;
int[] fibonacciArray = FibonacciArray(number);
Console.Write($"Если N = {number} -> ");
PrintArraySplitSpace(fibonacciArray);