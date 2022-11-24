/*Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.Write("Введите натуральное число N:");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M:");
int numM = Convert.ToInt32(Console.ReadLine());


void NaturalNumbers(int numN, int numM)
{    
          
        if (numN==numM) 
        {
            Console.Write($"{numN} ");
            return;
        }
        if (numN>=numM) 
        {
            Console.Write($"{numN} ");
            NaturalNumbers(numN-1, numM);
            
        }
        else if (numN<=numM) 
        {
            
            Console.Write($"{numN} ");
            NaturalNumbers(numN+1, numM);
            
            
        }
        
     
}

NaturalNumbers(numN, numM);