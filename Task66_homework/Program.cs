// Задача 66: Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов 
// в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

uint GetNaturalSum(uint numM, uint numN) 
// Вычисляет сумму натуральных элементов в промежутке от M до N
{
    if (numM > numN) // если M больше N - поменяем их местами.
    {
        uint temp = numN;
        numN = numM;
        numM = temp;
    }
    uint sum = GetNaturalSumRec(numM,numN);
    return sum;
}

uint GetNaturalSumRec(uint numM, uint numN) 
// Рекурсивно вычисляет сумму натуральных элементов в промежутке от M до N. 
{
    if (numM > numN) return 0;
    return numM + GetNaturalSumRec(numM + 1, numN);
}

uint numberM = 1;
uint numberN = 15;
uint naturalSum = GetNaturalSum(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {naturalSum}");
