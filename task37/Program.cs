/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
[1 2 3 4 5 6] -> 6 10 12*/

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
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] MultiplyArr(int[] array)
{
    int size = array.Length / 2;
    //если длина массива нечетная - увеличим его на 1 для того, чтобы вписать середину в результат
    if (array.Length % 2 != 0)
    {
        size = size + 1;
    }
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        //если пришли в середину нечетного массива - записываем сам элемент
        if (array.Length - i - 1 == i)
            resultArray[i] = array[array.Length - i - 1];
        //иначе - умножаем крайние элементы
        else
            resultArray[i] = array[i] * array[array.Length - i - 1];
    }
    return resultArray;
}
int[] arrayMulti1 = CreateArrayRndInt(5, 1, 10);
PrintArray(arrayMulti1);
int[] arrayMulti1res = MultiplyArr(arrayMulti1);
PrintArray(arrayMulti1res);
int[] arrayMulti2 = CreateArrayRndInt(4, 1, 10);
PrintArray(arrayMulti2);
int[] arrayMulti2res = MultiplyArr(arrayMulti2);
PrintArray(arrayMulti2res);
