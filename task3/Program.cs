/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int remain = a%2;
if (remain>0)
{
    Console.Write($"Число {a} нечетное");
}
else if (a!=0) 
{
    Console.Write($"Число {a} четное");
}
if (a==0)
{
    Console.Write($"Введенное число равно 0");
}