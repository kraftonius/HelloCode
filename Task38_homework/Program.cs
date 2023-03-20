// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// 1. Задать массив вещественных чисел
// 2. Найти максимальный и минимальный элементы
// 3. Вычислить разницу между максимальным и минмимальным элементами
// 4. Вывести ответ
// Образец: 
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] GenerateRndDoubleArray(int size, int min, int max)
// Создает массив вещественных чисел с одним знаком после запятой
// size - кол-во элементов. min и max - диапазон значений элементов
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

string DoubleToStringDotView(double num)
// возвращает как строку вещественное число с десятичной точкой вместо запятой
{
    return num.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"));
}

string DoubleArrayStringView(double[] arr)
// Возвращает массив вещественных чисел внутри квадратных скобок через запятую
// [49.8, 24.2, 28.8, 14] 
{
    string printArray = "[";

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            printArray += $"{DoubleToStringDotView(arr[i]),2}, ";

        else
            printArray += $"{DoubleToStringDotView(arr[i]),2}]";
    }
    return printArray;
}

double GetMaxDoubleElement(double[] arr)
// Возвращает максимальное вещественное число в массиве
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double GetMinDoubleElement(double[] arr)
// Возвращает минимальное вещественное число в массиве
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

// Зададим массив, найдем макс и мин элементы,
// вычислим разницу между макс и мин элементами
double[] array = GenerateRndDoubleArray(8, 0, 51);
double maxDoubleElement = GetMaxDoubleElement(array);
double minDoubleElement = GetMinDoubleElement(array);
double difference = Math.Round(maxDoubleElement - minDoubleElement, 1);

// Выведем ответ
string stringDifference = DoubleToStringDotView(difference);
Console.WriteLine($@"Масcив и разница максимального и минимального элементов: 
{DoubleArrayStringView(array)} - > {stringDifference}");