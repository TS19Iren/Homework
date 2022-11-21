/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("]");
    }
}

int GetSummOfRows (int[,] matrix, int row)
{
    int summ = default;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ=summ+matrix[row,i];
    }
    return summ;
}

int[] GetTheRowNumber(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[i] = GetSummOfRows(matrix,i);
    }
    return array;
}
void FindTheSmallerOne(int[] array)
{
    int min = array[0];
    int indexRow=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min) 
        {
            min = array[i];
            indexRow=i;
           
        }
    }
    Console.WriteLine($"Самая меньшая сумма элементов находится в {indexRow} строке");
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] matrixRnd = CreateMatrixRndInt(4,4,1,10);
PrintMatrix(matrixRnd);
int[] result = GetTheRowNumber(matrixRnd);
PrintArray(result);
FindTheSmallerOne(result);