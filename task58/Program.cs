/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Матрицу P можно умножить на матрицу K только в том случае, если число столбцов матрицы
P равняется числу строк матрицы K. Матрицы, для которых данное условие не выполняется, умножать нельзя.*/
Console.WriteLine("Введите количество строк в первой матрице: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первой матрице: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во второй матрице: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в первой матрице: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int rows, int columns, int min, int max)
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (columns1 != rows2)
        Console.WriteLine("Данные матрицы невозможно перемножить");
    else
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    multiMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        
    }
    return multiMatrix;
}

int[,] matrixA = CreateMatrix(rows1, columns1, 0, 10);
int[,] matrixB = CreateMatrix(rows2, columns2, 0, 10);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixA);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrixB);
int[,] resultMulti = MatrixMultiplication(matrixA, matrixB);
Console.WriteLine("Итоговая матрица: ");
PrintMatrix(resultMulti);
