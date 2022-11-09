// Задача 27: Напишите программу, 
//которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12n
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int FindSumOfNumbers(int a)
{
    int temp=a;
    int sum = default;
    while (temp>0)
    {
        sum=temp%10+sum;
        temp=temp/10;
    }
    return sum;
}

int resultSum = FindSumOfNumbers(userNumber);
Console.WriteLine(resultSum);
