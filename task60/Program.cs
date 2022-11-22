/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] CreateRnd3DArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] array = CreateArrayRandomElements(rows, columns, depth, min, max);
    int countOfArray = default;
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[countOfArray++];
            }
        }
    }
    return matrix;
}

int[] CreateArrayRandomElements(int rows, int columns, int depth, int min, int max)
{
    int[] array = new int[rows * columns * depth];
    Random rnd = new Random();
    int count = default;
    int temp = default;
    bool isExistElem = default;
    while (count < array.Length)
    {
        temp = rnd.Next(min, max + 1);
        for (int i = 0; i < array.Length; i++)
        {
            if (temp == array[i])
            {
                isExistElem = true;
                break;
            }
        }
        if (isExistElem == false)
        {
            array[count] = temp;
            count++;
        }
    }
    return array;
}
/*void PrintArray(int[] array)
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
}*/
void Print3DMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
             }
        }
    }
}

//int[] testarray = CreateArrayRandomElements(2, 2, 2, 10, 98);
//PrintArray(testarray);
int[,,] matrix3D = CreateRnd3DArray(2, 2, 2, 10, 98);
Print3DMatrix(matrix3D);