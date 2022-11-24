/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElemNumbers(int num)
{
    if(num==0) return num;
    return num%10 + SumElemNumbers(num/10);
}

int sumElemNumbers = SumElemNumbers(number);
Console.WriteLine($"Сумма цифр: {sumElemNumbers}");
