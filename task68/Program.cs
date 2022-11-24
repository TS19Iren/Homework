/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(!IsPositiveNum(numberM,numberN))  Console.WriteLine("Введите неотрицательное число!");
else Console.WriteLine(AccermanFunction(numberM,numberN));

int AccermanFunction (int numberM,int numberN)
{
    if(numberM==0) return numberN+1;
    else if ((numberM!=0)&&(numberN==0)) return AccermanFunction(numberM-1,1);
    else return AccermanFunction(numberM-1,AccermanFunction(numberM,numberN-1));
}

bool IsPositiveNum (int numberM, int numberN)
{
    return numberM>0&&numberN>0;
}