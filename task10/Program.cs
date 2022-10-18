// Напишите программу которая принимает на вход трехначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трехначное число: ");
int consoleNumber = int.Parse(Console.ReadLine());
if(consoleNumber>999||consoleNumber<100){
    Console.Write("Введите трехзначное число!");
}
else {
    int secondDigit = findSecondDigit(consoleNumber);
    Console.Write($"Результат: {secondDigit}");
}

int findSecondDigit (int consoleNumber)
    {
        return (consoleNumber/10)%10;
    }
