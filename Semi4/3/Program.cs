// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество цифр = {GetNums(num)}");



int GetNums(int num1)
{
    int  count = 0;
    while(num1 > 0)
    {
       num1 = num1/10;
       count++;
    }
    return count;
}

