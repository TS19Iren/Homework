/*Задача 40: Напишите программу, которая 
принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

bool CheckSides(int num1,int num2,int num3)

{
       
        bool b = (num1+num2>num3&&num2+num3>num1&&num1+num3>num2);
        return b;
}

bool result = CheckSides(num1,num2,num3);   
Console.WriteLine((result?"такой треугольник существует":"такого треугольника быть не может"));