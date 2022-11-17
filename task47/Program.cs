/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] CreateRndDoubleArray(int rows, int columns, int min, int max)
{
   
    double[,] doubleMatrix = new double [rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < doubleMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < doubleMatrix.GetLength(1); j++)
        {
            doubleMatrix[i,j] = Math.Round((min+(rnd.NextDouble() * (max - min))),2);
        }
    }
    return doubleMatrix;

}

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 7}");
            else
                Console.Write($"{matrix[i, j], 7}");
        }
        Console.WriteLine("]");
    }
}

double[,] doubleMatrix = CreateRndDoubleArray(rows,columns,-10,10);
PrintDoubleMatrix(doubleMatrix);