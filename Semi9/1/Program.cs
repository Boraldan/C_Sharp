// Через рекурсию!!!
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
 
Console.Clear();
Console.Write("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());
int K = 1;


Num(n, K);

int Num (int n, int k) {
if (k > n-1 ) return n ;
Console.Write(k + " ");
return Num(n, K + 1);
 
}


// void Main()
// {
//     Console.Clear();
//     Console.WriteLine("Start");
//     Console.WriteLine("Введите натуральное число: ");
//     int number = GetNumber();
//     ShowNaturalNumbers(number);

//     Console.WriteLine("End");
// }

// int GetNumber()
// {
//     return int.Parse(Console.ReadLine());
// }

// int ShowNaturalNumbers(int number)
// {
//     if(number < 1) return 1;

//     Console.Write($"{number} <- ");

//     return ShowNaturalNumbers(number - 1);
// }
// Main();