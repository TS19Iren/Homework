/*Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumElemFromMtoN(int m, int n)
{
    if (m == n)
        return n;
    else
    {
        return m + SumElemFromMtoN(m + 1, n);
    }
}

int sumOfElem = SumElemFromMtoN(numberM, numberN);
Console.WriteLine($"Сумма элементов от {numberM} до {numberN} равна: {sumOfElem}");
