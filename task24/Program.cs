// напишите программу которая 
//принимает на вход число А и 
//выдает сумму чисел от 1 до А
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int number)
{
    int sum = default;
    for (int i = 1; i <= number; i++)
    {
        sum = sum+i;
    }
    return sum;
} 
int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");
