// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



Console.Clear();

int EnterNum () {
Console.Write("Введите число Фибоначи: ");
int a = int.Parse(Console.ReadLine()!);
return a;
}

int n = EnterNum ();

int [] fibArr = new int[2]{0, 1};

Array.Resize(ref fibArr, n+2); // Решение 1: увеличиваем n на 2

for (int i = 0; i < n; i++) {
fibArr[i+2] = fibArr[i+1] + fibArr[i];  
Console.Write(fibArr[i] + ", ");
}
 
 
//  Решение 2: без увеличения n + 2

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


//  Решение 3: через Рекурсию в функции

// int Fibonachi(int n)
// {
//     if (n == 0 || n == 1) return n;
     
//     return Fibonachi(n - 1) + Fibonachi(n - 2);
// }
 
// int fib4 = Fibonachi(4);
// int fib5 = Fibonachi(5);
// int fib6 = Fibonachi(6);
 
// Console.WriteLine($"4 число Фибоначчи = {fib4}");
// Console.WriteLine($"5 число Фибоначчи = {fib5}");
// Console.WriteLine($"6 число Фибоначчи = {fib6}");


//  Решение 4: через цикл

Console.WriteLine(Fibonachi2(2));

static int Fibonachi2(int n)
{
    int result = 0;
    int b = 1;
    int tmp;
 
    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }
 
    return result;
}

 