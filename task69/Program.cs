/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.WriteLine("Enter first number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter first number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Involution(int a, int b)
{
    
    int inv = 1;
    if(b==1) return inv;
    else
    {
        inv = a*Involution(a,b-1);
        return inv;
    }
}

int involution = Involution(numA,numB);
Console.WriteLine($"Число А в степени В: {involution}");