// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
 
Console.WriteLine($"\nСумма чисел между {a} и {b} => {SumNum(a, b, 0)}");

int SumNum(int m, int n, int sum)
{   
    if(m > n) return sum;
    
    sum += m++;
    
    return SumNum(m, n, sum);
}

    

       
       