// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да



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
bool FindElement(int[] array,int userElement)
{   bool b = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]==userElement)
        {
            b=true;
            break;
        }
           
    }
    return b;
}
int[] arr = CreateArrayRndInt(12,0,15);

PrintArray(arr);
Console.Write("Введите число: ");
int userElement = Convert.ToInt32(Console.ReadLine());
bool b = FindElement(arr,5);
Console.Write(b?"да":"нет");