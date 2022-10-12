// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write ("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int i = 1;

while (i <= n) {
   if (i < n) {
       Console.Write(Math.Pow(i,2) + ", ");
   }
   else {
        Console.Write(Math.Pow(i,2) + ".");
   }

    i++;
}