// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"


Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());


EvNum(a);

int EvNum(int n)
{
    if(n==2) {
        Console.Write($"{n}, ");
        return n;}

    // if(n%2 != 0)    // меняем эту проверку на: n = (n/2)*2
    // {  
    //     Console.Write($"{--n}, ");
    //     return EvNum(n-2);
    // }
    
    // Console.Write($"{n}, ");

    Console.Write($"{n = (n/2)*2}, ");

    return EvNum(n-2);
}   
       