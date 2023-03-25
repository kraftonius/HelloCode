// Задача 68: Напишите программу 
// вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint Ackermann(uint n, uint m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackermann(n - 1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}

uint numM = 3;
uint numN = 2;
uint ackermann = Ackermann(numM, numN);
Console.WriteLine($"m = {numM}, n = {numN} -> A(m,n) = {ackermann}");
