/*Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7*/
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

int[] SearchingMinElem(int[,] matrix)
{
    int[] minElemArray = new int[2];
    int minElement = matrix[0, 0];
    minElemArray[0] = 0;
    minElemArray[1] = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minElemArray[0] = i;
                minElemArray[1] = j;
            }
        }
    }
    return minElemArray;
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


//Метод создает новый массив на основе matrix исключая строку из array[0] и столбец из array[1]
int[,] CreateMatrixWithoutOneRowColumn(int[,] matrix, int[] array)
{
    //массив куда будет сохранять данные
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    //индексы для сохраняемого массива
    int newI = 0;
    int newJ = 0;

//проходимся по "большому" массиву
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //в случае когда строчка не исключена из копирования - перебераем значения в ней
        if (i != array[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                //в случае когда столбец не изключен из копирования - сохраняем значения в итоговый массив
                if (j != array[1])
                {
                    newMatrix[newI, newJ] = matrix[i, j];
                    //Console.WriteLine($"Записываем значение {matrix[i,j]} в новую матрицу в позицию {newI}:{newJ}" );
                    //т.к. работаем с индексом столбца - увеличиваем
                    newJ++;
                }
            }
            //увеличиваем индекс строки
           newI++;
        }
        //при переходе на новую строчку надо сбросить индекс столбца
         newJ=0;
    }
    return newMatrix;
}

int[,] matrixRnd = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixRnd);
int[] resultArray = SearchingMinElem(matrixRnd);
PrintArray(resultArray);

int[,] smallerMatrix = CreateMatrixWithoutOneRowColumn(matrixRnd, resultArray);
PrintMatrix(smallerMatrix);
