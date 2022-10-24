/*Задача 23
Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
getNumberCubed(userNumber);

void getNumberCubed(int a)
{
int count = 1;
double resultNumber = 0;
while (count <= a)
{
    resultNumber = Math.Pow(count, 3);
    Console.WriteLine($"{count} | {resultNumber}");
    count++;
}
}

