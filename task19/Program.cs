/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Введите пятизначное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int copyUserNumber = userNumber;
if (userNumber > 99999 || userNumber < 10000)
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
        remainNumber = userNumber % 10;
        numberString = numberString + remainNumber;
        userNumber = userNumber / 10;
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
