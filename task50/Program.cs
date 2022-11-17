/*Задача 50. Напишите программу, которая
на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 5}");
            else
                Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("]");
    }
}


void SearchingForElement(int[,] matrix, int userRows, int userColumns)
{
    if (userRows < 0 || userColumns < 0)
        Console.WriteLine("Введите не отрицательные числа!");
    else if (userRows >= matrix.GetLength(0) || userColumns >= matrix.GetLength(1))
        Console.WriteLine("Такого элемента в массиве нет");
    else Console.WriteLine($"Искомый элемент: {matrix[userRows,userColumns]}");
}
int[,] matrixRnd = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrixRnd);
Console.WriteLine("Укажите строку элемента: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец элемента: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
SearchingForElement(matrixRnd,userRows,userColumns);