//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
    {
    int multNumbers = MultiNumbers(number);
    Console.WriteLine($"Произведение = {multNumbers}");
    }

else
    {
        Console.Write("Вы ввели некорректное число");
    }

int MultiNumbers(int multiNum)
    {
        int multi = 1;

        for (int i = 1; i <=multiNum; i++)
        {
            multi = multi*i;
        }
        return multi;
    }
    