/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

int[,] CreateMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i + j;
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} ", array[i, j]);

        Console.WriteLine("]");
    }
}

int[,] mtr = CreateMatrix(3, 5);
PrintMatrix(mtr);