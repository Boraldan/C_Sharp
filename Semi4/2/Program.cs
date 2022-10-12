// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
 
Console.WriteLine($"Произведение цифр = {GetSumNums(num)}");


int GetSumNums(int number)
{
    int proiz = 1;
    while(number > 0)
    {
        proiz *= number;
        number--;
    }
    return proiz;
}
