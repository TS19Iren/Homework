/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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

int[,] SortedMatrix(int[,] matrix)
{
    int[] tempArray = new int[matrix.GetLength(1)];
    int [] forCopy = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           forCopy[j]=matrix[i,j];
        }
        tempArray = SortingArray(forCopy);
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j]=tempArray[j];
        }
    }
    return matrix;
}

int[] SortingArray(int[] array)
{
    
    int temp = default;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] < array[j + 1])
        {
            temp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = temp;
        }       
        }
    }
    return array;
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

int[,] matrix = CreateMatrixRndInt(3,3,1,8);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
Console.WriteLine("Отсортированный массив: ");
SortedMatrix(matrix);
PrintMatrix(matrix);
