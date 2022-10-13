// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if(a>b)
{
    Console.Write($"Число {a} большее число, а число {b} меньшее число");
}
else if(a!=b)
{
    Console.Write($"Число {b} большее число, а число {a} меньшее число");
}
else {
    Console.Write("Числа равны");
}