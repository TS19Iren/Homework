// Пользователь вводит с клавиатуры М чисел.
//Посчитайте сколько чисел больше 0 ввел пользователь
Console.WriteLine("Введите количество чисел:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] CreateUserArray (int size)
{
    Console.WriteLine("Введите числа: ");
    int[] userArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
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

int HowManyNegNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<0) count=count+1;
    }
    return count;
}

int[] result = CreateUserArray(userSize);
PrintArray(result);
int howManyNegNumbers = HowManyNegNumbers(result);
Console.WriteLine($"Колличество отрицательных чисел в массиве из {userSize} элементов = {howManyNegNumbers}");
