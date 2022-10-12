// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter degree of number: ");
int degreeNumber = int.Parse(Console.ReadLine()!);
 
double Degree(int a, int b) {
    double result = Math.Pow(a,b);
    return result;
}

Console. WriteLine($"Degree {degreeNumber} of number {number} = {Degree(number, degreeNumber)}");