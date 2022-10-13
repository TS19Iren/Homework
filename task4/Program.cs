/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N==0)
{
    Console.Write("Невозможно выполнить операцию, введите число больше 0");
}
int count=1;

while (count<=N)
{
    if(count%2==0)
    {
        Console.Write($" {count} ");
    }
    count++;
}
