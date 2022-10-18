/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Write("Введите число: ");
int consoleNumber = int.Parse(Console.ReadLine());
if(consoleNumber<100){
    Console.Write("Третьей цифры нет!");
}
else {
    int thirdDigit = findThirdDigit(consoleNumber);
    Console.Write($"Третья цифра заданного числа: {thirdDigit}");
}

int findThirdDigit (int consoleNumber)
    {
        while (consoleNumber>=1000)
        {
            consoleNumber = consoleNumber/10;
        }
        return consoleNumber%10;
    }
