/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Введите пятизначное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int copyUserNumber = userNumber;
IsPalindrom(userNumber);

void IsPalindrom(int a)
{
if (a > 99999 || a < 10000)
{
    Console.WriteLine("Число не пятизначное!");
}
else
{
    int count = 1;
    int remainNumber = 0;
    string numberString = "";

    while (count <= 5)
    {
        remainNumber = a % 10;
        numberString = numberString + remainNumber;
        a = a / 10;
        count++;
    }
    
    int resultNumber = Convert.ToInt32(numberString);
    Console.WriteLine(resultNumber);
    if (resultNumber == copyUserNumber)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
}
