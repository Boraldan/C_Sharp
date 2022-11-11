// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// не верное решение, но рабочее 
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int num = int.Parse(Console.ReadLine());

// Console.Write(Sum(num));

// int Sum (int n) {

// if (n < 1) return 0;

// return n + Sum (n-1);

// }

Console.Clear();
Console.Write("Введите количество строк массива: ");
int num = int.Parse(Console.ReadLine());

Console.Write(Sum(num));

int Sum (int n) {

if (n < 1) return n;

return n%10 + Sum (n/10);

}