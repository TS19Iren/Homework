/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int [] CreateArray (int size,int min,int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    
}

int GetSumOfUnevenNumbers(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2!=0) sum=sum+array[i];
        
    }

    return sum;
}

int[] testArray = CreateArray(10,0,10);
PrintArray(testArray);
int resultSumm = GetSumOfUnevenNumbers(testArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {resultSumm}");

