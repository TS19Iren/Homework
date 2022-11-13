/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

double[] CreateDoubleArray(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble()*(max-min)+min),2);
    }
    return array;
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

double GetMinInArray(double[] array)
{
    double min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min>array[i]) min=array[i];
       
    }
    return min;
}
double GetMaxInArray(double[] array)
{
    double max=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max<array[i]) max=array[i];
       
    }
    return max;
}

double[] testArray = CreateDoubleArray(10,0.0,10.0);
PrintArray(testArray);
double minArray = GetMinInArray(testArray);
Console.WriteLine($"Минимальное значение: {minArray}");
double maxArray = GetMaxInArray(testArray);
Console.WriteLine($"Максимальное значение: {maxArray}");
double diff = Math.Round((maxArray-minArray),2);
Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");