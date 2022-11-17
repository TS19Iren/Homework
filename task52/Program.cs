/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
void PrintArray(double[] array)
{
    Console.Write("Сгенерированный массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}   ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
    
}

double[] AverageOfColumnsElements (int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double temp = default;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp=default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = matrix[i,j]+temp;
        }
        array[j] = temp/matrix.GetLength(0);
    }

    return array;
}
int[,] matrixRnd = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrixRnd);
double[] resultArray = AverageOfColumnsElements(matrixRnd);
PrintArray(resultArray);