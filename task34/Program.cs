/*Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] CreateRandomArray(int size)
{
        int[] arr = new int[size];
        Random el = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = el.Next(99,1000);
        }
        return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
     Console.WriteLine("]");
}

int HowManyNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) count++;
    }
    return count;
}

int[] testArray = CreateRandomArray(15);
PrintArray(testArray);
int count = HowManyNumbers(testArray);
Console.Write(count);