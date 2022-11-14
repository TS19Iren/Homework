/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string BinarNumber(int number)
{
    string st = "";
    while(number>0)
    {
        if(number%2!=0) st="1"+st;
        else st="0"+st;
        number=number/2;
    }
    return st;
}

string BinarRecurcy (int userNumber, string st)
{
    if (userNumber==0) return st;
    else BinarRecurcy(userNumber/2,userNumber%2+st);

}

Console.WriteLine(BinarNumber(userNumber));
