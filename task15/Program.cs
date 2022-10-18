/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());
isWeekend(number);
void isWeekend(int number)
    {
        if (number==6||number==7)
        {
            Console.Write("да");
        }
        else
        {
            Console.Write("нет");
        }
    }
