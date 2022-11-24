/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int userNumber)
{
    if (userNumber==0) return;
    Console.Write($"{userNumber} ");
    NaturalNumbers(userNumber-1);
    
}

NaturalNumbers(userNumber);