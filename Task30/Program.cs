// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}


void PrintArray(int[] arra)
{
    Console.Write("[");
    for (int j = 0; j < arra.Length - 1; j++)
    {
        Console.Write($"{array[j]},");
    }
    Console.Write($"{array[arra.Length - 1]}]");
}

