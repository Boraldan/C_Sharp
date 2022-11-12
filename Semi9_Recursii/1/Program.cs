// Через рекурсию!!!
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
 
Console.Clear();
Console.Write("Введите количество строк массива: ");
int N = int.Parse(Console.ReadLine());
int k = 0;

Num(N, k);

int Num (int n, int i) 
{
    if (n==0) return n ;
    Console.Write(((n- --n) + i++) + " ");
    return Num(n, i);
}
