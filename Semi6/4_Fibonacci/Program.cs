// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Clear();

int EnterNum () {
Console.Write("Введите число Фибоначи: ");
int a = int.Parse(Console.ReadLine()!);
return a;
}

int n = EnterNum ();

int [] fibArr = new int[2]{0, 1};

Array.Resize(ref fibArr, n+2); // Решение 2: увеличиваем n на 2

//  Решение 1: без увеличения n + 2

// if (n <= 2)  
// Console.Write($"{fibArr[0]}, {fibArr[1]} ");

// else
// {
// Console.Write($"{fibArr[0]}, {fibArr[1]}, ");

// for (int i = 2; i < n; i++)
// {
// fibArr[i] = fibArr[i-1] + fibArr[i-2];
// Console.Write(fibArr[i] + ", ");
// }
// }


for (int i = 0; i < n; i++) {
fibArr[i+2] = fibArr[i+1] + fibArr[i];  // решение 2
Console.Write(fibArr[i] + ", ");
}
 
 
 