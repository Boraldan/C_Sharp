// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49


Console.Write("Enter int:");
int x = int.Parse(Console.ReadLine());
x = x*x;
Console.WriteLine("Int = " + x);
