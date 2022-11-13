// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if (N >1000 || N < 100) 
{Console.Write("Введите правильное число");}
else{N = N%10;
Console.WriteLine("Последнее знак в числе N: " + N);}
