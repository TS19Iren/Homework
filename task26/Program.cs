// Напишите программу которая
//принимает на вход число
//выдает количество цифр в числе
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
    number = Math.Abs(number);
    int count = default;
    
   while (number>0)
   {
    number=number/10;
    count++;
   }
   return count>0? count:1;
        
}
int sumDigit = SumDigit(num);
Console.Write($"Количество цифр в числе  = {sumDigit}");