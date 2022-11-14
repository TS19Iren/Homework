/*Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.*/

Console.WriteLine("Введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] array)
{    
    int[] copyArray =new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] arr = CreateArrayRndInt(size, min, max);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Копия массив");
int[] copyArr = CopyArray(arr);
PrintArray(copyArr);
