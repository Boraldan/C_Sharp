// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

CheckSides(EnterNum(),EnterNum(),EnterNum());

int EnterNum () {
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
return a;
}
 
void CheckSides (int a, int b, int c) {
if (a < b+c && b < a + c && c < a + b)
Console.Write("да ");
else 
Console.Write("нет ");
}