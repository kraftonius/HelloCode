// Задача 29: 
// Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// 1,2,5,7,19,6,1,33 -> [1,2,5,7,19,6,1,33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 101); // от 0 до 100
    }
}


void PrintArray(int[] arra)
{
    for (int j = 0; j < arra.Length - 1; j++)
    {
        Console.Write($"{array[j]},");
    }
    Console.Write($"{array[arra.Length - 1]}");
    
    Console.Write(" -> [");
    for (int k = 0; k < arra.Length - 1; k++)
    {
        Console.Write($"{array[k]},");
    }
    Console.Write($"{array[arra.Length - 1]}]");
}