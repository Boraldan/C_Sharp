// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Clear();

Fibonacci(EnterNum ());

int EnterNum () {
Console.Write("Введите число Фибоначи: ");
int a = int.Parse(Console.ReadLine()!);
return a; 
}


void Fibonacci(int n) {

    int [] fibArr = new int[2]{0, 1};
    Array.Resize(ref fibArr, n+2);  
    for (int i = 0; i < n; i++) {
    fibArr[i+2] = fibArr[i+1] + fibArr[i];  
    Console.Write(fibArr[i] + ", ");   
    
    } }