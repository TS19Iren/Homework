// SЗадача 31: Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rnd.Next(min,max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1)Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CreateArrayRndInt(12,-9,9);
PrintArray(arr);

int[] GetSumPosNegElem(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) sumPositive+=array[i];
        else sumNegative+= array[i];
    }
    return new int[]{sumPositive,sumNegative};
}
int[] getSumPosNegElem = GetSumPosNegElem(arr);
Console.Write($"Сумма положительных элементов = {getSumPosNegElem[0]}. Сумма отрицательных элементов = {getSumPosNegElem[1]}");